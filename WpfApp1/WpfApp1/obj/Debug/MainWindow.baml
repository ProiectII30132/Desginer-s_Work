   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � WindowStyle$
 None=�60    � 
ResizeMode$ NoResize=�6C    � WindowStartupLocation$ CenterScreen=�6Y    � Triggers 5
      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/    g� Duration$ 0:0:1D�66   	 �� TargetProperty$	 Opacity�6G   5      5      5      5      .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #C5E1A5��6#   � 5      $ #33691E��6#    � Offset$ 1Q�63   � 5      $ #8BC34A��6#   $	 0.5Q�63   5       5"      �� 5#   
   $��Assests/Logo.png��6   $	��200��6*   $	��200��67   $	��Top=�6C   $��20q�6[   �� 5$   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusY$
 14.5��6d    �� RadiusX$
 14.5��6s    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         Color$ 	#FFBBBBBB��6#      
BlurRadius$ 15Q�65      	Direction$ 0Q�6E      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5(      � 5)   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5*      �� $��Login��6   $��Center=�6&   $	��Top=�6C   $��5q�6[   
�������$��18(�6x   �� 5+      $��Center=�6   $��10q�64   .+�5,      �� -   5         ��Name$ emailTextBox��5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��60    %  !MaterialDesignFloatingHintTextBox#��[  6W   $��Champagne & Limousines)�6�   $��18(�6�   G� 5-      -   5         G�Name$ passwordPasswoerdBox��5-      $ Password��6<    ) %MaterialDesignFloatingHintPasswordBox#��[ 6f   $��Champagne & Limousines)�6�   $��18(�6�   5.      �� 5/      -   5         ��Name$ fpTextBlock��5/      $��Forgot password?��6Y   $��Right=�6q   $��Bottom=�6�   $��10,40q�6�   
������� � Cursor$
 Hand��6�   �� 50      $��Remember me��6   $
��Left=�6-   $��Bottom=�6H   $��10,40q�6c   
�������$
 Hand��6�   52      �� 53   
   -   5         ��Name$ loginButton��53      $	��150��6&   ���#8BC34A$��Center=�6G   $��Bottom=�6d   $��100,0,100,77q�6   $��Login��6�   6�   �� 54   
   -   5        $ signUpTBlock��54   A   $"��New here? Create an account!��6W   $��Center=�6{   $��Bottom=�6�   $��30q�6�   
�������$
 Hand��6�   A� 55   
   -   5        
���  ��$��10��55   !   $��10��6-   $	��Top=�68   $��Right=�6P   $��10,10q�6l    57        58      $ 0Q�6#   $	 0.1Q�61   5;      5<      5=      