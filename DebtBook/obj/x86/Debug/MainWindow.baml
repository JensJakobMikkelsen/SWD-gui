   M S B A M L   `   `   `  ����?  ;Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DebtBookAssignmentDebtBookAssignment  5   	   #    DebtBookAssignment.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2local clr-namespace:DebtBookAssignment     5   	     � 
ResizeMode$  NoResize=�5   	   $	��400��5   	   $��410.076��6    � Title 5   	   ��  �� Path$ Title� � 	Resources 5         DebtorTemplate �� Padding��%�   &	        �� 5
   
   .R�5      � .+�5      �� $
 5, 0q�68   $	��100��5      ��5      �� $ ¨Name�5      �� 5      $
 5, 0q�68   $	��100��5      ��5      �� $ Value�5      5      5      5       � DataContext 5      !   DebtBookAssignment.DebtBook  5   
   -   5        Debtors��5      .��5      ]� -   5        $��dockPanelMain��5      $��0,0,26,-0.5q�6%   .+�5   
   � -   5        $��
DebtorGrid��5      $��
0,0,0,-0.5q�6!   $	��511��65   .+�5!      &   System.Windows.Controls.DataGrid  -   5        $��dgridDebtors��5%         AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�5"      $��10,65,0,1.5q�5&         CanUserAddRows .  	   CanUserDeleteRows	 .  
   
IsReadOnly
 .    MinRowHeight$ 12Q�5+      $
��Left=�6*   $	��250��6E   ��5!      ��  �� SelectedIndex 5#      �� $ CurrentIndex� �� SelectedItem 5$      �� $ CurrentDebtor�   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$
 Debt��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� $ Value�  5/      $
 Name��6)    67   �� $
 Name�57      �� 58      -   5         ��Name$ add_debtor_btn��58      $��
Add Debtor��6-   $
��Left=�6B   $��
297,68,0,0q�6]   $	��Top=�6q   $��75��6�   ��6�   �� *
AddCommand+�� 59      $
��Left=�6   $��	10,49,0,0q�63   $
��Wrap=�6F   $��Debtors:��6Z   $	��Top=�6j   �� 5:      -   5        $ edit_debtor_btn��5:      $��edit_Debtor��6.   $
��Left=�6D   $��297,111,0,0q�6_   $	��Top=�6t   $��75��6�   ��6�   �� *EditCommand+5;      5<      5=      