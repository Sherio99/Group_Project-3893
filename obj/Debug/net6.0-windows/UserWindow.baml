   M S B A M L   `   `   `  ����H  DGroup_project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Group_projectGroup_project  5   	       Group_project.UserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Group_project     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)   $��0,50,0,0q�65    � DataContext 5	          Group_project.UserWindowVM  5
   
   5      .��5      � .+�5   
   �� ��5      �� 5       �� ImageSource$E ?/macos-purple-abstract-background-hd-wallpaper-1920x1080-77.jpg��6   .+�5      �� $
��Left=�6   $��295,15,0,29.8q�61    �� TextWrapping$
 Wrap=�6H   $�� Student Details��6\   $	��Top=�6t   $	��262��6�   $��28(�6�   $
��Bold"�6�   $��Impact)�6�    J� RenderTransformOrigin$ 0.495,0.508&�6�   $��37��6�   ��6�   Z� .��6  ��5      �� 5       �� Color$ 	#FF090000��6&    �� Opacity$	 0.8Q�68   .��5   &   ��5      �� 5      $ 	#FFD6D6D6��6&   $ 0Q�68   .��5   &   5      �� 5      ���	#FFE9EEEC$��30 0 0 0q�6/   $O��I  Student ID                       Student Name                       GPA��6A   $	��736��6�   
���   �6�   �� 5      -   5         ��Name$ Listview��5      $��30 20 20 20q�6*   
������ ��6Y   �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedItem	 5       �� *SelectedStudent+$ PropertyChanged=���5!      �� 5"      .R�5#      �� 
������ 
���   �$��1q�6N   
 �� Padding$	
 0.1q�5$   !    �� CornerRadius$ 5��6/   $	��850��6@   $��90��6L   ._�5%      ��  �� Orientation$ 
Horizontal=�6*   $
��Left=�6C   .+�5(   "   �� 
���   �$��45 0 0 0q�6?   $
��Bold"�6�   ��6Q   �� *Id+$ PropertyChanged=�6�   �� 5)   "   ���	#FF0E0606$��	110 0 0 0q�6C   $
��Bold"�6�   ��6V   �� *Name+$ PropertyChanged=���6�   Z� 6�   �� 5*   "   ���	#FF120707$��	122 0 0 0q�6C   $
��Bold"�6�   ��6V   �� *Gpa+$ PropertyChanged=�6�   50      52      53      56      �� 57      $ 
Horizontal=�6   .+�58      �� $��Create��6   $
��Left=�6*   $��105,-10,0,0q�6E   $	��Top=�6Z   $��38��6r   $	��126��6~   $��1q�59   /   ���	#FFF2FF00
�������$��16(�6n   $
��Bold"�6|   $��	Agency FB)�6�   ��6   �� *CreateCommand+��5;      �� 5<      $ 	#FFD82B43��6*   $	 0.5Q�6<   5>      �� 5?      $��Refresh��6   $
��Left=�6+   $	��Top=�6F   $��38��6^   $	��126��6j   $��
30,-10,0,0q�6v   $ 
-0.276,0.1&�6�   ���	#FFFCFF01$��16(�6�   $
��Bold"�6�   $��	Agency FB)�6�   ���	#FFF2EEEE��5@      �� *RefreshCommand+��5A      �� 5B      $ 	#FFBD2F2F��6*   $	 0.5Q�6<   5E      �� 5G      $��Update��6   $
��Left=�6*   $��
30,-10,0,0q�6E   $	��Top=�6Y   $��38��6q   $	��126��6}   ���	#FFFEF207���	#FFFDFDFD$��	Agency FB)�6�   $��16(�6�   $
��Bold"�6�   ��5H      �� *UpdateCommand+��5I      �� 5J      $ 	#FFA31F1F��6*   $	 0.5Q�6<   5L      �� 5M      $��Delete��6   $
��Left=�6*   $��
30,-10,0,0q�6E   $	��Top=�6Y   $��38��6q   $	��126��6}   ���	#FFFEF207���	#FFFDFDFD$��	Agency FB)�6�   $��16(�6�   $
��Bold"�6�   ��5N      �� *DeleteCommand+��5O      �� 5P      $ 	#FF8F1515��6*   $
 0.45Q�6<   5R      5S      5T      5U      5V      