   M S B A M L   `   `   `  ����J  FZingMp3CrawData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZingMp3CrawDataZingMp3CrawData  5   	        ZingMp3CrawData.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ZingMp3CrawData     5   	     � Title$  
MainWindow��5   	   $	��768��6   $
��1366��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5
       �� Source�� 5   
   $ 
Style.xaml?�6   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��500* �6   �� 5      $
��858* �6   .+�5   
   � $��2��6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      .+�5      �  5      �� 5      6)   �� 5      6)   �� 5      6)   .+�5"      � $��0��6   $��0��6$   .+�5#      d� -   5         d�Name$ 
btnVietNam��5#   #    d� 	IsChecked 67   �� *IsCheckVietNam+.��6\   BXH Việt Nam6j   5$      � 5%      $��0��6   $��1��6$   .+�5&      d� -   5        $ btnAuMy��5&   #    64   �� *IsCheckAuMy+.��6V   BXH Âu Mỹ6a   5'      � 5(      $��0��6   $��2��6$   .+�5)      d� -   5        $ 
btnHanQuoc��5)   #    67   �� *IsCheckHanQuoc+.��6\   BXH Hàn Quốc6j   5*      5+      � 5.      $��1��6   .+�50      �� -   5         ��Name$ 
lsbTopSong��50      $��Stretch=�6.   ��51      �� 52      .R�53      �� -   5        $	��460��53   B   $��Stretch=�6N   $��80��6k   $��1q�6w   ���#cccccc	 �� Padding$	 10q�6�   $��0 0 0 5q�6�   ._�54   "   �  55   &   �� 56   *   $��30 �6;   6I   �� 57   *   $��65 �6;   6I   �� 58   *   6>   .+�5:   &   � $��0��6+   .+�5;   *   �� $��Center=�65   $��Center=�6R   ��6m   �� *rakingStatus+6�   5<   '   � 5=   &   $��1��6+   .+�5>   *   �� $��5q�60   $
��Fill=�6;   ��6J   �� *	thumbnail+5?   +   5@   '   � 5A   &   $��2��6+    5B   *   �� 5C   .   $
��auto �6<   6L   �� 5D   .   6>   .+�5F   *   � $��0��6/   .+�5G   .   �� $��0 5 0 10px q�68   $��DemiBold"�6M   
����  ���6u   �� *title+6�   5H   +   � 5I   *   $��1��6/   .+�5J   .   �� ��68   �� *artistsNames+6X   5K   +   5L   '   5M   #   5N      5O      5Q      5R      5U      � 5V   
   $��1��6   .+�5W      (  "System.Windows.Controls.WebBrowser  -   5        
  Name$
 wbMain��5W      6Q   5X      5Y      5Z      