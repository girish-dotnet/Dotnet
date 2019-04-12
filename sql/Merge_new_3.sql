DECLARE @MergeOutput TABLE
(
  ActionType NVARCHAR(10),
  DelTitleID INT,
  InsTitleID INT,
  DelTitle NVARCHAR(50),
  InsTitle NVARCHAR(50),
  DelQuantity INT,
  InsQuantity INT
);
 
MERGE BookInventory bi
USING BookOrder bo
ON bi.TitleID = bo.TitleID
WHEN MATCHED AND
  bi.Quantity + bo.Quantity = 0 THEN
  DELETE
WHEN MATCHED THEN
  UPDATE
  SET bi.Quantity = bi.Quantity + bo.Quantity
WHEN NOT MATCHED BY TARGET THEN
  INSERT (TitleID, Title, Quantity)
  VALUES (bo.TitleID, bo.Title,bo.Quantity)
WHEN NOT MATCHED BY SOURCE
  AND bi.Quantity = 0 THEN
  DELETE
OUTPUT
    $action,
    DELETED.TitleID,
    INSERTED.TitleID,
    DELETED.Title,
    INSERTED.Title,
    DELETED.Quantity,
    INSERTED.Quantity
  INTO @MergeOutput;
 
SELECT * FROM BookInventory;
 
SELECT * FROM @MergeOutput;