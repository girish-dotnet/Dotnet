   M S B A M L   `   `   `  ����  WpfDataBindingApplication4    .WpfDataBindingApplication.InlineXmlDataBinding   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  InlineXmlDataBinding��5   	   $	��300��6&   $	��300��63    � 	Resources 5         SoccerTeams��%�  &	        � 5   
   .��5      ��<Teams xmlns="">
                    <Country Name="USA">
                        <BestPlayer>Kasey Keller</BestPlayer>
                    </Country>
                    <Country Name="England">
                        <BestPlayer>Joe Cole</BestPlayer>
                    </Country>
                    <Country Name="Japan">
                        <BestPlayer>Nakata</BestPlayer>
                    </Country>
                </Teams>        5      5      .��5      � .+�5   
   �� -   5        $��
lvwPlayers��5      ��5      ��  �� Source# [   �� XPath$ /Teams/Country�� �� View 5      �� 5      .P�5      �� $��Country��6%    �� Width$	 100��5   %    �� DisplayMemberBinding 5   %   �� $ @Name��5   %   �� 5      $��Best Player��6%   $	 100��5!   %    5    %   �� $ 
BestPlayer��5!   %   5"      5$      5%      5&      