   M S B A M L   `   `   `  ����  WPF45NewFeatures!    WPF45NewFeatures.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $��510.527��6   $��628.158��6-   .��5      �  � RowDefinitions 5   
   �� 5      $	��13* �6   �� 5	      $	��75* �6   .+�5   
   �� $#��Using Live Shaping => Sorting��6   $��40(�68   $
��Bold"�6F   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgproducts��5         AutoGenerateColumns .  $
��Left=�6C   $��	25,10,0,0q�6^   $��1��5      $	��Top=�6    $	��334��68   $	��356��6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ProductId��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	ProductId+6X     5      $ ProductName��6E    6%   �� *ProductName+6\     5      $ Price��6?    6%   �� *Price+6P   5      �� 5   
   -   5         ��Name$ btnlivesort��5      $��	Live Sort��6&   $
��Left=�6:   $��
406,50,0,0q�6U   $��1��6i   $	��Top=�6v   $	��170��6�    J� RenderTransformOrigin$ 
1.107,0.65&�6�   $��51��6�   $��30(�6�   $
��Bold"�6�   6�   5      5      