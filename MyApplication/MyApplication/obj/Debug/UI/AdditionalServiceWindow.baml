   M S B A M L   `   `   `  ����H  DMyApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MyApplication.UIMyApplication.UI  5   	   .    (MyApplication.UI.AdditionalServiceWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MyApplication.UI     5   	     � Title$  AdditionalServiceWindow��5   	   $	��300��6)   $	��300��66    � SizeToContent$ WidthAndHeight=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5         TextBoxErrorTemplate��%d   &	        �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5      �� 5      5      5      .��5      � .+�5   
   �� $
��Name��6   $
��Left=�6   $��25��6:   $��	10,10,0,0q�6F   $	��Top=�6Y   $��83��6q   �� 5   
   $��Price��6   $
��Left=�6    $��25��6;   $��	10,56,0,0q�6G   $	��Top=�6Z   $��83��6r   �� 5   
   -   5        $��tbName��5   _    =� ErrorTemplate# [  6   $
��Left=�6m   $��25��6�   $��	98,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��177��6�   .��6  ��5      �� 5       �� Path$
 Name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&   	 �� ValidationRules	 5      +   %MyApplication.UI.StringValidationRule  5      5      .��5      5       �� 5!   
   -   5        $��tbPrice��5!   _   # [  6   $
��Left=�6n   $��25��6�   $��	98,56,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��177��6�   .��6  ��5"      �� 5#      $ Price�6   $ PropertyChanged=�6'   	 5$      *   $MyApplication.UI.PriceValidationRule  5%      5'      .��5(      5)      �� 5*   
   -   5        $!��btnAddEditAdditionalService��5*      $	��Add��64   $
��Left=�6B   $��30��6]   $��97,123,15,15q�6i   $	��Top=�6   $��80��6�   6�   �� 5+   
   
 �� IsCancel
 . $��Cancel��6!   $
��Left=�62   $��30��6M   $��195,123,15,15q�6Y   $	��Top=�6p   $��80��6�   5-      5.      