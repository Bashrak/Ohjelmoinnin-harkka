   M S B A M L   `   `   `  ����L  HTyöajan_seuranta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Työajan_seurantaTyöajan_seuranta  5   	   *    $Työajan_seuranta.EditEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Työajan_seuranta     5   	     � Title$#  Muokkaa työntekijän tietoja��5   	   $��230.769��6-   $��616.864��6>   .��5	      � .+�5
   
   �� .+�5      �� -   5         ��Name$ comboBox��5      $��Center=�6)   $��10q�6F   $	��Top=�6R   $	��220��6j    J� RenderTransformOrigin$ 0.182,0.506&�6v   .@�5      �� -   5         ��Name$ addUser��5      $��Lisää käytttäjä...��6)   $	��200��6F   $��Center=�6R   5      �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�66   .+�5      �� -   5         ��Name$ ConfirmEdit��5      $��Center=�6.   $��5q�6K   $��Tallenna muutokset��6V   $	��124��6s   �� 5      -   5        $ DeleteEmployee��5      $��Center=�61   $��5q�6N   $��Poista��6Y   $	��125��6j   �� 5      -   5        $ Cancel��5      $��Center=�6)   $��5q�6F   $��Peruuta��6Q   $	��125��6c   5      �� 5      $ 
Horizontal=�6   .+�5      �� $
��Left=�6   .+�5      �� $
��Left=�6    $	�� 17��6;   $��	30,10,0,0q�6H   $��Etunimi��6[   $��80��6j   �� 5      $
��Left=�6    $	�� 17��6;   $��	30,10,0,0q�6H   $��Sukunimi��6[   $��80��6k   �� 5      $
��Left=�6    $	�� 17��6;   $��	30,10,0,0q�6H   $��Salasana��6[   $��80��6k   �� 5      $
��Left=�6    $	�� 17��6;   $��	30,10,0,0q�6H   $��Admin��6[   $��80��6h   5      �� 5      $
��Left=�6   .+�5      �� -   5         ��Name$ txt_FirstName��5      $
��Left=�65   $	�� 17��6P   $��	30,10,0,0q�6]   $��80��6p   �� 5      -   5        $ txt_LastName��5      $
��Left=�64   $	�� 17��6O   $��	30,10,0,0q�6\   $��80��6o   �� 5      -   5        $ 
txt_Passwd��5      $
��Left=�62   $	�� 17��6M   $��	30,10,0,0q�6Z   $��80��6m   �� 5      -	   5        $ txt_IsAdministrator��5      $
��Left=�6;   $	�� 17��6V   $��	30,10,0,0q�6c   $��80��6v   5      &   System.Windows.Controls.DataGrid  5       $��20,0,0,0q�6      AlternatingRowBackground
 ����� �� AlternationCount$ 2��6j   ��6-   �� 	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Päivämäärä��6-     5#      $
 Töiden alku��6-     5$      $
 Töiden lopetus��6-     5%      $
 Paikalla��6-   5'      5(      5)      5*      5+      