   M S B A M L   `   `   `  ����F  BContactBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ContactBookContactBook  5          ContactBook.PearsonPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ContactBook     5      -   5          N� Title$  PearsonPage��5	       � 	Resources 5      .   (ContactBook.NullableIntToStringConverter    NullableIntToStringConverter.   (ContactBook.BooleanToVisibilityConverter  BooleanToVisiblityConverter��%:   &	        &	        5   
   6-     5   
   6-   5      .��5      � $��Center=�6   $��Center=�6(    � ColumnDefinitions 5   
   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6%   $
��Left=�62   $��Stretch=�6M   ���	#FFFFD26E.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��
First Name��6   $��90��6/   $��10 0 0 0q�6:   $
��Bold"�6L   �� 5      $��	Last Name��6   $��90��6-   $
��Bold"�68   �� 5      $��Street��6   $��90��6*   $
��Bold"�65   �� 5       $��	House No.��6   $��90��6-   $
��Bold"�68   �� 5!      $��Apartment No.��6   $��90��61   $
��Bold"�6<   �� 5"      $��Postal Code��6   $��90��6/   $
��Bold"�6:   �� 5#      $
��Town��6   $��90��6(   $
��Bold"�63   �� 5$      $��	Phone No.��6   $��90��6-   $
��Bold"�68   �� 5%      $��Date of Birth��6   $��90��61   $
��Bold"�6<   �� 5&      $	��Age��6   $��90��6'   $
��Bold"�62   5'      5(      �� 5)   
   $��0��6   $��1��6'   $	��300��64   $	��500��6D   $	��450��6Q   .��5*      �� .+�5+      �� $��10q�6C   ��6   �� *PearsonList+��5,      �� 5-      .R�50      �� $ 
Horizontal=�6)   .+�51   "      ContactBook.Pearson  {�60   �� *	IsEditing+ �� Mode$ TwoWay=��� 53   "   $��2 0 0 0q�54   F   
�������
���������53   )   �� *DataContext.EditDataProvider+ �� RelativeSource ��  �� AncestorType" ����54   )   �� .��55   &   �� $��/Icons/edit.png��6,   $��15��6E   56   #   �� 58   "   $��2 0 0 0q�59   >   
�������
���������58   )   �� *DataContext.DeleteFromTable+ �� " ����59   !   �� .��5:   &   �� $��/Icons/delete.png��6,   $��15��6G   5;   #   �� 5=   "   $��2 0 0 0q�5?   3   
�������
���������5=   )   �� *DataContext.AcceptEditData+ �� " ����5>   %   �� y�6B   �� *	IsEditing+ �� 	Converter# [ $ TwoWay=�.��5@   &   �� $��/Icons/save.png��6,   $��15��6E   5A   #   5C      5F      5H      �� 5J      $��0��6   $��2��6-   $ 
Horizontal=�6:   .+�5K      �� $��90��6F   ��6   �� *	FirstName+$ TwoWay=�6F   �� 5L      $��90��6E   ��6   �� *
LastName+$ TwoWay=�6E   �� 5M      $��90��6G   ��6   �� *
StreetName+$ TwoWay=�6G   �� 5N      $��90��6�   ��6   �� *HouseNumber+# [  $ TwoWay=�6�   �� 5O      $��90��6�   ��6   �� *ApartmentNumber+# [  $ TwoWay=�6�   �� 5P      $��90��6G   ��6   �� *
PostalCode+$ TwoWay=�6G   �� 5Q      $��90��6A   ��6   �� *Town+$ TwoWay=�6A   �� 5R      $��90��6�   ��6   �� *PhoneNumber+# [  $ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5S      $	��100��6S   	   SelectedDate	 6!   �� *DateOfBirth+$ TwoWay=�6S   �� 5T      $��90��6y   ${�False��6�   ��6   �� *Age+# [  $ TwoWay=�6�   �� 5U      $	��ADD��6   $
��Bold"�6+   $��50��6d   $��10 0 0 0q�6o   ���	#FFFFA400��6=   �� *AddPearsonCommand+6�   5W      �� 5X      $��0��6   $��2��6-   $ 
Horizontal=�6:   $��Center=�6S   .+�5Y      �� $����Your entered data is incorrect. Please try filling out the form again. Remember to enter digits in numeric fields, and ensure that the phone number contains exactly 9 digits.��6}   
���  ��$
��Bold"�5Z   1   y�5Y       �� *ErrorDataInfo+# [ 5Z   1   5[      5\      5]      �� 5_   
   $��0��6   $��3��6%   $��Center=�62   $��Stretch=�6O   $ 
Horizontal=�6k   .+�5`      �� $
��SAVE��6<   $
��Bold"�6L   ���	#FFFFA400$��50��6�   $	��150��6�   $��25q�6�   {�6   �� *SynchronizeData+��6^   �� *UpdateDatabase+6�   �� 5a      $��CANCEL��6<   $
��Bold"�6M   ���	#FFFFA400$��50��6�   $	��150��6�   $��25q�6�   {�6   �� *SynchronizeData+��6_   �� *CancelUpdates+6�   5b      5c      5d      