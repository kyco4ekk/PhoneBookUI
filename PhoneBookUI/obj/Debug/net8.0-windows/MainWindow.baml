   M S B A M L   `   `   `  ����  PhoneBookUI    PhoneBookUI.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ed7http://schemas.microsoft.com/expression/blend/2008/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ Manual=�5
   	    � Left$	 150��5   	   
 � Top$	 150��6    � AllowsTransparency$
 True��5   	   
������ '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CornerRadius$ 20��6   	   CaptionHeight$	 0Q�5      
   ResizeBorderThickness$
 0q�5         GlassFrameThickness$ 0q�5      .��5      � $��94,0,0,0q�6   $	��450��6   $��Center=�6*   .+�5   
   �� 
����������	#FFB0B0B0$��1q�6<    �� CornerRadius$ 20��6P   $��
0,10,-1,10q�5       �� Padding$ 10q�6%    J� RenderTransformOrigin$ 0.5,0.5&�62   $��Right=�6R   $	��407��6n   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.285Q�6$   �� 5      T� 5       T� Y$ -1.195Q�6)   5       J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         Color$ 	#80000000��6#      
BlurRadius$ 10Q�65      	Direction$	 270Q�6E      ShadowDepth$ 5Q�6U   ._�5#      � .+�5%      �� 
����������	#FFB0B0B0$��1q�6D   $ 15��6X   $��
98,61,96,7q�5&      $ 2q�6-   ._�5'      �� -   5         ��Name$ contacts_tb��5'       �� 
IsReadOnly$
 True��63    �� TextWrapping$
 Wrap=�6E   $�� ��6Y   $	��332��5(      $��Center=�6+   " �� VerticalScrollBarVisibility$
 Auto=�5)      $��0q�5*      
������ $��6,0,6,0q�6K   5+      �� 5/      -   5        $ searchContact��50      $
 Wrap=�6,   $#��Поиск контактов��6@   $��26��51      $	��Top=�6*   $
��Left=�6B   $	��164��6]   
�������$��1q�54      
�������$��98,1,0,0q�6E   �� 57      -   5        $%��Добавить контакт��57      $��98,31,154,351q�64   6K   �� 59      -   5        $
��Left=�59      $��	354,0,0,0q�64   $	��Top=�5:      $��31��61   $��27��6<   
������ 
������ .��5<      �� $j��dC:\Users\kyco4ekk\Desktop\Телефонная книга C#\PhoneBookUI\PhoneBookUI\Image\close.png��6   $��27��6{   $��23��6�   5>      5?      5@      5A      5B      