   M S B A M L   `   `   `  ����E  Apodgotovka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:podgotovka
podgotovka  5          podgotovka.UserPge   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:podgotovka     5      -   5          N� Title$  UserPge��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5      $
��329* �6   �� 5      $	��62* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��250��6.   .+�5      �� $��Найти:��6   $��Center=�6&   $��20(�6A   6Q   �� 5      -   5         ��Name$ 
TBoxSearch��5      $	��175��6C   $��30��6O   6]   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DGridUser��5   N   $��1��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *UserSurname+6b     5      $ Имя��6%   $	 * 6O   
 62   �� *
UserName+6[     5      $ Отчество��6%   $	 * 6Z   
 67   �� *UserPatronymic+6f     5      $ 
Логин��6%   $	 * 6T   
 64   �� *	UserLogin+6`     5      $ Пароль��6%   $	 * 6V   
 65   �� *UserPassword+6b     5      $ Роль��6%   $	 * 6U   
 63   �� *Role.RoleName+6a   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5       �� 5!      .R�5"      �� -   5        $ ��Редактировать��5"   %   6U   5#      5%      5(      �� 5*   
   -   5        $��2��5*      $��30��6   $	��100��6*   $��Center=�66   $��Right=�6Q   $��Добавить��6m   6�   �� 5+   
   -   5        $��2��5+      $��30��6   $	��100��6*   $��Center=�66   $��Center=�6Q   $��Удалить��6n   6�   5-      5.      