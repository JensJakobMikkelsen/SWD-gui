   M S B A M L   `   `   `  ����?  ;Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DebtBookAssignmentDebtBookAssignment  5   	   '    !DebtBookAssignment.EditDebtWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2local clr-namespace:DebtBookAssignment     5   	   $��364.023��5   	   $��316.8��6     � WindowStartupLocation$  CenterOwner=�5   	    � ShowInTaskbar .   � 
ResizeMode$ NoResize=�5       � WindowStyle$ 
ToolWindow=�65    +� FocusedElement 5   	   ��  �� ElementName$ tbxId�� � 	Resources 5      ��%    5       � DataContext 5      !   DebtBookAssignment.DebtBook  5   
   -   5        	questions��5      .��5      � $��0,0,-0.4,2.6q�6   .+�5   
   �� $��0,8,238.8,-0.4q�6   $
��Debt��6(   �� 5   
   $��0,39,264.8,-0.4q�6   $
��Name��6)   �� 5   
   -   5        $��tbxId��5   0   $��25��6   $��92,8,0,0q�6   $��0��6=   $	��Top=�5      $
��Left=�6*   $	��188��6E   ��5      ��  �� Path$ Value��� 5   
   -   5        $��tbxCodeName��5   1   $��25��6   $��	92,39,0,0q�6   $��1��5      $	��Top=�5      $
��Left=�5   -   $	��188��6H   ��6   �� $
 Name�6H   �� 5    
   -   5        $��btnOk��5#      	 �� 	IsDefault	 . $��4��5!      $��92,0,131.8,229.6q�5"      $��Bottom=�5$      $��20��5%   %   .��61   _Save68   �� 5&   
   -   5        $��	btnCancel��5)      
 �� IsCancel
 . $��5��5'      $��0,0,30.8,229.6q�5(      $��Right=�5*      $��71��5+      $��20��6   $��Bottom=�6(   .��6C   	_Cancel6L   �� 5,   
   $
��Left=�6   $	��147��6-   $	��Top=�6:   $	��188��6R   $��
92,146,0,0q�6^   ��6r   �� $ EditedValues�52      53      