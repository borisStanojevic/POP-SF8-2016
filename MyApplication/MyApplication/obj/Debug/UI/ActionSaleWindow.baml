   M S B A M L   `   `   `  ����H  DMyApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MyApplication.UIMyApplication.UI  5   	   '    !MyApplication.UI.ActionSaleWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MyApplication.UI     5   	     � Title$  ActionSaleWindow��5   	   $	��300��6"   $	��300��6/    � WindowStartupLocation$ CenterScreen=�6;    � 	Resources 5
         TextBoxErrorTemplate��%d   &	        �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5      �� 5      5      5      .��5      � .+�5   
   �� $
��Name��6   $
��Left=�6   $��	10,10,0,0q�6:   $	��Top=�6M   $��79��6e   �� 5   
   $��Discount��6   $
��Left=�6#   $��	10,51,0,0q�6>   $	��Top=�6Q   $��79��6i   �� 5   
   $��
Start Date��6   $
��Left=�6%   $��	10,96,0,0q�6@   $	��Top=�6S   $��79��6k   �� 5   
   $��End Date��6   $
��Left=�6#   $��
10,149,0,0q�6>   $	��Top=�6R   $��79��6j   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dpStartDate��5      $
��Left=�6P   $��26��6k   $��
103,97,0,0q�6w   $	��Top=�6�   $	��160��6�      SelectedDate 6(   ��  �� Path$ 	StartDate�6�     5   
   -   5        $��	dpEndDate��5      $
��Left=�6L   $��26��6g   $��103,149,0,0q�6s   $	��Top=�6�   $	��160��6�    6&   �� $ EndDate�6�   �� 5   
   -   5        $��tbName��5   _    =� ErrorTemplate# [  6   $
��Left=�6n   $��26��6�   $��103,10,15,15q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��160��6�   .��6  ��5      �� 5      $
 Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&    �� ValidationRules 5      +   %MyApplication.UI.StringValidationRule  5      5      .��5       5!      �� 5"   
   -   5        $��
tbDiscount��5"   _   # [  6   $
��Left=�6q   $��26��6�   $��103,55,15,15q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��160��6�   .��6  ��5#      �� 5$      $ Discount�6   $ PropertyChanged=�6*    5%      -   'MyApplication.UI.DiscountValidationRule  5&      5(      .��5)      5*      �� 5+   
   -   5        $��btnAddEditActionSale��5+      $	��Add��6-   $
��Left=�6;   $��28��6V   $��103,210,0,0q�6b   $	��Top=�6w   $��74��6�   6�   �� 5,   
   $��Cancel��6   $
��Left=�6"   $��28��6=   $��189,210,0,0q�6I   $	��Top=�6^   $��74��6v   	 �� IsCancel	 . 6�   5.      5/      