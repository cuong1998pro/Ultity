   M S B A M L   `   `   `  ���� J  FZingMp3CrawData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZingMp3CrawDataZingMp3CrawData       ZingMp3CrawData.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:ZingMp3CrawData       � Title$  
MainWindow��$	��768��$
��1366�� � WindowStartupLocation$ CenterScreen=� � 	Resources  �� Source�� $ 
Style.xaml?�%    .���  � ColumnDefinitions �� $
��500* ��� $
��858* �.+�� $��2�� � RowDefinitions �� $
��auto ��� .+��  �� �� �� .+�� $��0��$��0��.+�d� -    d�Name$ 
btnVietNam�� d� 	IsChecked �� *IsCheckVietNam+.��BXH Việt Nam� $��0��$��1��.+�d� -   $ btnAuMy�� �� *IsCheckAuMy+.��BXH Âu Mỹ� $��0��$��2��.+�d� -   $ 
btnHanQuoc�� �� *IsCheckHanQuoc+.��BXH Hàn Quốc� $��1��.+��� -    ��Name$ 
lsbTopSong��$��Stretch=����� .R��� -   $	��460��$��Stretch=�$��80��$��1q����#cccccc	 �� Padding$	 10q�$��0 0 0 5q�._��  �� $��30 ��� $��65 ��� .+�� $��0��.+��� $��Center=�$��Center=����� *rakingStatus+� $��1��.+��� $��5q�$
��Fill=����� *	thumbnail+� $��2�� �� $
��auto ��� .+�� $��0��.+��� $��0 5 0 10px q�$��DemiBold"�
����  ����� *title+� $��1��.+��� ���� *artistsNames+� $��1��.+�(  "System.Windows.Controls.WebBrowser  -   
  Name$
 wbMain��