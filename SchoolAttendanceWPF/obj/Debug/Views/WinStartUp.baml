   M S B A M L   `   `   `  ����N  JSchoolAttendanceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolAttendanceWPF.ViewsSchoolAttendanceWPF.Views  5   	   *    $SchoolAttendanceWPF.Views.WinStartUp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:SchoolAttendanceWPF.Views     5   	   -   5          � Title$
  Menu��5   	   $��397.526��6   $	��300��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $
��Wrap=�6   $��School Year��6(   $��4q�6;   �� 5   
   -   5         ��Name$ cmbSchoolYear��5      $��1��6*   $��4q�67   6t   �� 5   
   -   5        $ cmbSchoolterm��5      $��3��6*   $��4q�67   6B   �� 5   
   $��2��6   $
��Wrap=�6!   $��School Term��65   $��4q�6H   �� 5   
   $��4��6   $
��Wrap=�6!   $��Level��65   $��4q�6B   �� 5   
   -   5        $ cmbSchoolLevel��5      $��5��6+   $��4q�68   6C   �� 5   
   $��6��6   $
��Wrap=�6!   $��Class��65   $��4q�6B   �� 5   
   -   5        $ cmbClass��5      $��7��6%   $��4q�62   �� 5   
   -   5         ��Name$ btnViewData��5      $��	View Data��6&   $��8��6:   $��4,20,4,4q�6G   $��40��6Y   �� 5   
   -   5         ��Name$ 
txtMessage��5      $��9��6(   $
��Wrap=�65   $��Stretch=�6I   $��Stretch=�6g   $��..��6�   $��4,10,4,4q�6�   5"      5#      