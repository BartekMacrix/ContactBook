   M S B A M L   `   `   `  ����F  BContactBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ContactBookContactBook  5          ContactBook.PearsonPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ContactBook     5        N� Title$  PearsonPage��5	      .��5      � $��Stretch=�6   $��Stretch=�6)    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6%   $��Stretch=�5      $	��400��6+   $��20q�6;   
�������.+�5      �� $��First Name:��6   �� 5      ��6   �� *	FirstName+ �� Mode$ TwoWay=��� 5      $��
Last Name:��6   �� 5      ��6   �� *
LastName+$ TwoWay=��� 5      $��Street Name��6   �� 5       ��6   �� *
StreetName+$ TwoWay=��� 5"      $��House Number��6   �� 5#      ��6   �� *HouseNumber+$ TwoWay=��� 5%      $��Apartment Number��6   �� 5&      ��6   �� *ApartmentNumber+$ TwoWay=��� 5(      $��PostalCode Name��6   �� 5)      ��6   �� *
PostalCode+$ TwoWay=��� 5+      $
��Town��6   �� 5,      ��6   �� *Town+$ TwoWay=��� 5.      $��Phone Number��6   �� 5/      ��6   �� *PhoneNumber+$ TwoWay=��� 51      $��Dat Of Birth��6   �� 52      ��6   �� *DateOfBirth+$ TwoWay=��� 54      $	��Age��6   �� 55      ��6   �� *Age+$ TwoWay=��� 57      $��Dodaj��6   ��6%   �� *AddPearsonCommand+�� 58      $��Edytuj��6   59      �� 5;   
   $��1��6   $��0��6%   $��Stretch=�62   $��Stretch=�6P   
�������.+�5<      �� $	��300��6   $	��300��6+   $	��450��68   .��5=      �� $��10q�6C   ��6   �� *PearsonList+��5>      �� 5?      .R�5@         ContactBook.Pearson  5A      5C      5D      5E      �� 5G   
   $��1��6   $��1��6%   $��Stretch=�62   $��Stretch=�6P   
���  ��.+�5H      �� $��Dodaj��6   5I      5J      5K      