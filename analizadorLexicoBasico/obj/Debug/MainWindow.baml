   M S B A M L   `   `   `  ����Q  ManalizadorLexicoBasico, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:analizadorLexicoBasicoanalizadorLexicoBasico  5   	   '    !analizadorLexicoBasico.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:analizadorLexicoBasico     5   	     � Title$  Analizador Léxico��5   	   $��383.6��6#   $��553.023��62    � ShowInTaskbar .   � Icon$R Lc8ebb9947fe4f57d2bf706184c620895-abrir-icono-de-libro-de-texto-by-vexels.png��6X   .��5
      � $��	0,0,3.6,0q�6   ���	#FFF4F4F4 � ColumnDefinitions 5   
   �� 5      $	��39* �6   �� 5      $
��233* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ 	labTitulo��5      $"��ANALIZADOR LÉXICO BÁSICO
��6#   $
��Left=�6P   $��14.5,10,0,0q�6k   $	��Top=�6�   $��25(�6�   $
��Bold"�6�   $��43��6�   $	��360��6�   $��1��6�   �� 5   
   $��Ingrese algún dato:��6   $
��Left=�6.   $��	37,62,0,0q�6I   $	��Top=�6\   $��15(�6t   $��2��6�   �� 5   
   -   5         ��Name$ 
txtEntrada��5      $��30��6&   $��37,97,34.2,0q�62    �� TextWrapping$
 Wrap=�6H   $	��Top=�6\   $	��472��6t   $��15(�6�   
���   �
�������$��2��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.013Q�6&   T� 5      5      .��5   '   5      �� 5   
   -   5        	 ��Name$	 leerEntrada��5      $��ANALIZAR��6&   $
��Left=�69   $��
37,140,0,0q�6T   $	��Top=�6h   $	��472��6�   $��15(�6�   $��2��6�   $��34��6�   6�   �� 5   
   $��Tokens encontrados:��6   $
��Left=�6.   $��
37,190,0,0q�6I   $	��Top=�6]   $��2��6u   $	��152��6�   $��15(�6�   �� 5   
   -   5        
 ��Name$
 listSalidas��5      $
��Left=�6'   $	��104��6B   $��
37,225,0,0q�6O   $	��Top=�6c   $	��472��6{   $��2��6�   5       5!      