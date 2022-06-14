;#DropDB XafSaveActionEasyTest

#Application XafSaveActionWin
#Application XafSaveActionBlazor

*FillForm
 User Name = Admin
*Action Log In

#IfDef XafSaveActionWin

*Action About...
 
*Action OK

#EndIf

#IfDef XafSaveActionBlazor
*Action Navigation(My Details)
#EndIf
