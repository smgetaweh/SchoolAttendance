   M S B A M L   `   `   `  ����N  JSchoolAttendanceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolAttendanceWPF.ViewsSchoolAttendanceWPF.Views  5   	   3    -SchoolAttendanceWPF.Views.WinUpdateAttendance   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:SchoolAttendanceWPF.Views     5   	     � Title$  WinUpdateAttendance��5   	   $��393.609��6%   $��662.03��66   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   � $��43��6   $	��Top=�6   $��1��63    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��1* �6#   �� 5      $
��Auto �6#   �� 5      $��1* �6#   .+�5      �� $
��Wrap=�6   $��Subject:��6,   $��4q�6<   �� 5      $��2��6   $
��Wrap=�6(   $��Attendance Date:��6<   $��4q�6T   �� 5      $��1��6   $��4q�6'   (  "System.Windows.Controls.DatePicker  5      $��3��6   $��4q�6)   5      9� 5   
   $��Expander��6   $��2��6%   .��5      � ���	#FFE5E5E5 5      �� 5      $
��Auto �6'   �� 5       $��1* �6'   �� 5!      $
��Auto �6'   �� 5"      $��1* �6'   .+�5$      �� $
��Wrap=�6   $��First Name:��60   $��4q�6C   �� 5%      $��2��6   $
��Wrap=�6,   $��
Last Name:��6@   $��4q�6R   �� 5&      $��1��6    �� TextWrapping$
 Wrap=�6*   $��TextBox��6>   $��4q�6M   �� 5'      $��3��6   $
 Wrap=�6*   $��TextBox��6>   $��4q�6M   5(      5)      &   System.Windows.Controls.DataGrid  5*   
   $��3��6      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Student��6%     5-      $ Status��6%     5.      $ Notes��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64   52      �� 53   
   $
��Wrap=�6   $��Uodate Student Attendance��6(   $��4q�6I   55      56      