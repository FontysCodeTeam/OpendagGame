   M S B A M L   `   `   `  ����B  >OpenDag, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OpenDagOpenDag  5   	       OpenDag.QuestionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OpenDag     5   	   -   5          � Title$  QuestionWindow��5   	   $	��480��6    $
��1400��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��280 �6   6-   �� 5      $	��280 �6   6-   �� 5      $	��280 �6   6-   �� 5      $	��280 �6   6-   �� 5      $	��280 �6   6-    � RowDefinitions 5   
   �� 5      $	��280 �6   6+   �� 5      6   .+�5   
   �� -   5         ��Name$ imgBusiness��5   %   $y�Visible=�6   $��0��6:   $��0��6G   $��10q�6W   $��images/Business.png��6c   6�   �� 5   
   -   5        $ imgInfrastructure��5   %   $y�Visible=�6   $��0��6@   $��1��6M   $��10q�6]   $��images/Infrastructure.png��6i   6�   �� 5   
   -   5        $ imgMedia��5   %   $y�Visible=�6   $��0��67   $��2��6D   $��10q�6T   $��images/Media.png��6`   6z   �� 5   
   -   5        $ imgSoftware��5   %   $y�Visible=�6   $��0��6:   $��3��6G   $��10q�6W   $��images/Software.png��6c   6�   �� 5   
   -   5        $ imgTechnology��5   %   $y�Visible=�6   $��0��6<   $��4��6I   $��10q�6Y   $��images/Technology.png��6e   6�   �� 5   
   -   5         ��Name$ 
tbQuestion��5   )   $y�Visible=�6   $��5��6=   $��1��6Q   $��0��6^   $A��;Welke van deze afbeeldingen vind jij het meest interessant?��6n   $��50(�6�   $��20q�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $ tbQuestionTwo��5   (   $y�Hidden=�6   $��5��6?   $��0��6S   $��0��6`   $!��Vind je ...... interessant?��6p   $��50(�6�   $	��100q�6�   $ Center=�6�   �� 5   
   -	   5         ��Name$ btnJa��5   %   $y�Hidden=�6   $��1��64   $��1��6A   $��Ja��6Q   $��30(�6^   $��40q�6l   6x   �� 5   
   -
   5        $ btnNee��5   %   $y�Hidden=�6   $��1��65   $��3��6B   $	��Nee��6R   $��30(�6`   $��40q�6o   6{   5       5!      