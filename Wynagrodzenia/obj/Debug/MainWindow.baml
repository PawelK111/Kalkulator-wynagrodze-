   M S B A M L   `   `   `  ����H  DWynagrodzenia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WynagrodzeniaWynagrodzenia  5   	       Wynagrodzenia.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Wynagrodzenia     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��550��5      $
��1177��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ CanMinimize=�6Y    � WindowStyle$
 None=�6r    � 	Resources 5	         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5
   
   .��5      U� $ (FrameworkElement.Width)�6,   $ Menuleft��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 220Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ Menuleft��6a   .\�5        $ 0��6'   $	 220Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5"      � -   5        
�������.+�5#   
   � -   5         �Name$ TitleTop��5#      $��60��6!   $	��Top=�6-   $��2��6E   ���	#FF00C500.+�5$      �� $��Kalkulator wynagrodzeń��6   $��Center=�66   $��Center=�6S   
�������$��22(�6�   �� 5%      -   5         0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5%      
�������$��1077,10,55,10q�6�   $
��Auto��6�   ��6[   Z� ��6q   Z� .��5&      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�6*   $��25��6@   $��25��6K   5'      �� 5(      -   5        #��[ 5(      
�������$��1127,10,5,10q�6�   $
��Auto��6�   ��6[   Z� ��6q   Z� .��5)        $ Close=�6*   $��25��67   $��25��6B   5*      5+      &   System.Windows.Controls.DataGrid  5,   
   -   5          Name$ 
Lista_plac��5,      $
��Left=�6'   $��	60,60,0,0q�6B      
IsReadOnly . $	��Top=�6g   $
��1117��6   $	��300��6�   ���	#FFBBBBBB���	#DD000000 5.      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5/      "  6   .�50      ��  � �� �	#FF008B0063   �� 51       � ��
 �����63   �� 52       � ��$ 0,0,1,2q�68   �� 53       � ��
 �   �64   54      55         Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$	 Lp.��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6T   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 62   �� *liczba_porzad+6a     58      $ Płaca podst.��6%   $	 120 6`    6;   �� *placa_podstawowa+6n     59      $ Dodatki��6%   $	 120 6R    66   �� *	dodatki+6`     5:      $ Wynagr. Brutto��6%   $	 120 6_    6=   �� *wynagr_brutto+6m     5;      $ Ubezp. emerytalne��6%   $	 120 6e    6@   �� *ubezp_emerytalne+6s     5<      $ Ubezp. rentowe��6%   $	 120 6_    6=   �� *ubezp_rentowe+6m     5=      $ Ubezp. chorobowe��6%   $	 120 6c    6?   �� *ubezp_chorobowe+6q     5>      $ Ubezp. zdrowotne��6%   $	 120 6c    6?   �� *ubezp_zdrowotne+6q     5?      $ Podatek do US��6%   $	 120 6Z    6<   �� *	podatekUS+6h     5@      $ Wynagr. Netto��6%   $	 120 6]    6<   �� *wynagr_netto+6k   5D      �� 5F   
   -   5         ��Name$ oblicz_button��5F      $��Oblicz��6(   $
��Left=�69   $��200,487,0,0q�6T   $��20(�6i   $
��Bold"�6w   $	��Top=�6�   $	��121��6�   $��38��6�    � Cursor$
 Hand��6�    �� 	IsDefault . ���	#FF00D300���	#FF2B68006  �� 5G   
   -   5         ��Name$ placapodstText��5G      $
��Left=�6*   $��31��6E    �� TextWrapping$
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��121��6�   $��200,365,0,0q�6�    J� RenderTransformOrigin$ 0.508,0.511&�6�    �� 
CaretBrush �	#FF00AF00 �� SelectionBrush �	#FF00AF006�   �� 5H   
   -   5        $ dodatkiText��5H      $
��Left=�6'   $��31��6B   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��121��6�   $��200,401,0,0q�6�    �	#FF00AF00 �	#FF00AF006�   �� 5I   
   -	   5        $ nieskladkoweText��5I      $
��Left=�6,   $��33��6G   $
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��121��6�   $��200,438,0,0q�6�    �	#FF00AF00 �	#FF00AF006�   �� 5J   
   $��Płaca zasadnicza:��6   $
��Left=�6,   $	��Top=�6G   $��
71,365,0,0q�6_   $	��124��6s   ���	#FF040404$
��Bold"�6�   $��14(�6�   $��31��6�   �� 5K   
   $��Dodatki:��6   $
��Left=�6#   $	��Top=�6>   $��127,401,0,0q�6V   $��68��6k   
���   �$
��Bold"�6�   $��14(�6�   $��31��6�   �� 5L   
   $��Dodatki nieopod.:��6   $
��Left=�6,   $	��Top=�6G   $��
65,438,0,0q�6_   $	��130��6s   
���   �$
��Bold"�6�   $��14(�6�   $��33��6�   $ 0.277,0.452&�6�   � 5N   
   -
   5        $ Menuleft��5N      $��60��6!   $
��Left=�6,   ���	#FF009104.+�5O      �� .+�5P      � $	��150��6   
�������$��0,0,0,0q�67   .+�5Q      �� -   5        $ ButtonCloseMenu��5Q      $	��Top=�66   $��Right=�6N   $y�	Collapsed=�6�   ��6j   Z� ��6�   Z� .��5R        
���   �$ 	ArrowLeft=�6E   $��25��6V   $��25��6a   5S      �� 5T      -   5        $ ButtonOpenMenu��5T      $	��Top=�65   $��Right=�6M   ��6i   Z� ��6   Z� .��5U        
���   �$
 Menu=�6E   $��25��6Q   $��25��6\   5V      5W      �� 5X      $��Disabled=�6   ���	#FF00C500$	��356��6h   $��0,0,0,0q�6u   .@�5Y      �� -   5         ��Name$ ExcelExport��5Y   /   $��71��6#   .��5Z      ��  �� Orientation$ 
Horizontal=�6%   .+�5[        $ 	FileExcel=�66   $��25��6G   $��25��6R   $��Center=�6^   $��10q�6y   �� 5\      $ ��Eksoprtuj do arkusza Excel��6(   
�������$��19��6]   5]      5^      �� 5_      -   5        $ ExcelImport��5_   /   $��70��6#   .��5`      �� $ 
Horizontal=�6%   .+�5a        $ 
FileImport=�66   $��25��6H   $��25��6S   $��Center=�6_   $��10q�6z   �� 5b      $��Importuj z arkusza Excel��6(   
�������$��19��6[   5c      5d      �� 5e      -   5        $ DeleteOneRows��5e   /   $��70��6#   .��5f      �� $ 
Horizontal=�6%   .+�5g        $ DeleteVariant=�66   $��25��6K   $��25��6V   $��Center=�6b   $��10q�6}   �� 5h      $��Usuń wybrany wiersz��6(   
�������$��19��6V   5i      5j      �� 5k      -   5        $ DeleteAllRows��5k   /   $��70��6#   .��5l      �� $ 
Horizontal=�6%   .+�5m        $ Delete=�66   $��25��6D   $��25��6O   $��Center=�6[   $��10q�6v   �� 5n      $��Usuń wszystkie dane��6(   
�������$��19��6V   5o      5p      �� 5q      -   5        $��70��5q   #   .��5r      �� -   5          ��Name$  Shutdown��5r   B   $ 
Horizontal=�6)   .+�5s   "     $ Power=�6:   $��25��6G   $��25��6R   $��Center=�6^   $��10q�6y   �� 5t   "   $��Zakończ��6,   
�������$��19��6N   5u      5v      5w      5x      5y      5z      5{      