   M S B A M L   `   `   `  ����e  aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089iMclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.RibbonSystem.Windows.Controls  5   	    PresentationLayer.   (PresentationLayer.Main_Forms.frmEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c	RibbonWinMclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Ribbon     5   	     � Title$  Employee��5   	   $	��500��6   $
��1000��6'    � WindowState$ 	Maximized=�64    � WindowStartupLocation$ CenterScreen=�6L    � WindowStyle$ ThreeDBorderWindow=�6q   .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5
   
   �� 5      $	��472 �6   .+�5   
   +   %System.Windows.Controls.Ribbon.Ribbon  -   5          Name$ 	RibbonWin��5       �� SelectedIndex$ 0��6%   
�������$��
0,0,-0.4,0q�6J      ApplicationMenu 5      :   4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5      .@�5      >   8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  $��Options��60   3   -System.Windows.Controls.Ribbon.RibbonMenuItem	   ImageSource$5	 //PresentationLayer;component/Images\options.png��6A     5      $
��Exit��60   $2	 ,/PresentationLayer;component/Images\quit.png��6>   5      
   HelpPaneContent
 5      1   +System.Windows.Controls.Ribbon.RibbonButton  5         SmallImageSource$2 ,/PresentationLayer;component/Images/help.png��6      QuickAccessToolBar 5      =   7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5        -   5          Name$
 Save��5   #   $2 ,/PresentationLayer;component/Images\save.png��62   6   0System.Windows.Controls.Ribbon.RibbonSplitButton  5      -   5          Name$
 Undo��5   (   5   /System.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$2 ,/PresentationLayer;component/Images\undo.png��67   .@�5      8	   2System.Windows.Controls.Ribbon.RibbonSplitMenuItem	  $��Undo 1��6.   	  5      $��Undo 2��6.   	  5      $��Undo 3��6.   5        5      -   5        $
 Redo��5   (   $2 ,/PresentationLayer;component/Images\redo.png��66   .@�5       	  $��Redo 1��6.   	  5!      $��Redo 2��6.   5"      5#      .@�5&      .
   (System.Windows.Controls.Ribbon.RibbonTab
  $
��Home��6   .@�5'      0   *System.Windows.Controls.Ribbon.RibbonGroup  -   5          Name$ Employee��5'      $��Employee��60   .@�5(           LargeImageSource$6 0/PresentationLayer;component/Images/personal.png��6'      Label$ Employee��6k    � ToolTip$$ Click to view employee options��6|   .@�5)        -   5        $��ButtonAddEmployee��5)   )   $6	 0/PresentationLayer;component/Images/personal.png��6B   $��Add Employee Information��6�     5*      -   5        $��ButtonEditEmployee��5*   )   $6	 0/PresentationLayer;component/Images/personal.png��6D   $��Edit Employee Information��6�     5+      -   5        $��ButtonDeleteEmployee��5+   )   $6	 0/PresentationLayer;component/Images/personal.png��6F   $��Delete Employee��6�   5,      5-      5.      
  5/      $��Interns��6   50      
  51      $��Leave��6   52      
  53      $��Training��6   54      
  55      $��
Compliance��6   56      
  57      $��Leads��6   58      
  59      $��Supervision Plan��6   5:      
  5;      $��Late Arrival��6   5<      5=      5>      5?      