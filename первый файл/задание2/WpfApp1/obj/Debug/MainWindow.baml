   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? 
??????.+?5
   
   ?? $??	0,0,600,0q?6   $??Center=?6(   .+?5      ?? $??Paint??6   $??	0,60,0,15q?6%   $??20(?68   $??Ravie)?6F   ?? 5      $??Цвет кисти:??6   ?? 5      $??0,0,0,10q?6   .@?5      ?? -   5        $	??Red??5      5   "   ?? 5      -   5        $??Green??5      5   #   ?? 5      -   5        $
??Blue??5      5   #   ?? 5      -   5        $
??Aqua??5      5   #   ?? 5      -   5        $??Purple??5      5   #   ?? 5      -   5        $??Yelow??5      5   #   ?? 5      -   5        $
??Gray??5      5   #   5      ?? 5      $??Размер кисти:??6   $??0,0,0,5q?6-   ?? 5      -   5         ??Name$ slider??5#      $??28??5       ?? IsSelectionRangeEnabled . 
??????? ? Minimum$ 1Q?5        ? Maximum$	 100Q?6!   $??0,0,0,5q?6/    ?? TickPlacement$ BottomRight=?5!       ?? IsSnapToTickEnabled .  ?? TickFrequency$ 5Q?5$   <   ?? 5&      -	   5        $??	sizeLable??5&      $??18??6)    ?? TextAlignment$ Center=?5'      ?? 5(      $??Chanse brash:??6   $??Ravie)?6-   $??0,0,0,10q?6@   	? 5)      -
   5        	 	?Name$		 Rb1??5*      
 	? 	GroupName$

 Boot??5)      $??0,0,0,5q?5*      .??6A   Рисовать6K   	? 5+      -   5        $		 Rb2??5,      $

 Boot??5+      $??0,0,0,5q?5,      .??6/   Редактирование6?   	? 5-      -   5        $		 Rb3??5.      $

 Boot??5-      .??50      Удаление6   51      ?? 54   
   -   5         ??Name$ InCnvs??54      $??	200,0,0,0q?6$    ?? DefaultDrawingAttributes 55      *  $System.Windows.Ink.DrawingAttributes  56         Color$ Black??6$      Height$ 10Q?62      Width$ 10Q?6>   58      59      5:      