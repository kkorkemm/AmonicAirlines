   M S B A M L   `   `   `  ����I  EAmonicSession1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AmonicSession1.Pages.AdminPagesAmonicSession1.Pages.AdminPages  5      3    -AmonicSession1.Pages.AdminPages.AdminMenuPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:AmonicSession1.Pages.AdminPages     5        N� Title$'  !AMONIC Airlines Automation System��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   o� $��5q�6   .@�5      m� -   5         m�Name$ MenuAdd��5      $��Add user��5      5      m� 5      -   5        $ MenuExit��5      $
��Exit��5      5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�5      $��10q�5      .+�5!      �� $��Office: ��6   �� 5"      -   5         ��Name$ ComboOffice��5"       �� DisplayMemberPath$ Title��5#      $	��200��5$      $��Center=�5%       �� SelectedIndex$ 0��5&      5'      5)      &   System.Windows.Controls.DataGrid  5+   
   -   5          Name$ 	GridUsers��5/      $��2��5+         AutoGenerateColumns .  	   
IsReadOnly	 . $��10q�5.      
   Columns
 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 54   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 55   %   �� *	FirstName+  56      $ 	Last Name��6%   $ * 57   %    58   %   �� *
LastName+  59      $	 Age��6%   $
 0.5* 5:   %    5;   %   �� *Age+  5<      $ 	User Role��6%   $ * 5=   %    5>   %   �� *Roles.Title+  5?      $ Email Address��6%   $ 2* 5@   %    5A   %   �� *Email+  5B      $ Offices��6%   $ * 5C   %    5D   %   �� *Offices.Title+5G      � 5I   
   $��3��6    � Orientation$ 
Horizontal=�5J      $��10q�5K      .+�5M      �� -   5         ��Name$ 	BtnChange��5M      $��Change Role��5N         
BlueButton#��[  5P      $	��200��5Q      $��10q�5R      �� 5T      -   5        $ BtnLogin��5T      $��Disable/Enable Login��5U        OrangeButton#��[ 5W      $	��200��5X      $��10q�5Y      5[      5]      5^      