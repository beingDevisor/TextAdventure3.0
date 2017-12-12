Public Class Form1
    Dim intHealth, intMagic, intAttack, intShield, intHold, intEnAttack, intEnHealth, intBones As Integer
    Dim blnRiddle As Boolean = False
    Dim blnShop As Boolean = False
    Dim blnBattle As Boolean = False
    Dim blnCharge As Boolean = False
    Dim blnBoss As Boolean = False
    Dim blnFirstTry As Boolean = False
    Dim strState As String = "NOTSTARTED"
    Dim strHold As String
    Dim intScore As Integer = 0
    Dim intRooms As Integer = 0
    Dim random As New System.Random
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Commands:" & vbCrLf & "Advance - Advances through the world" & vbCrLf & "Attack - Attacks the enemy using your attack stat" & vbCrLf & "Magic - Does something good, costs magic points" & vbCrLf & "Dodge - Chance for the enemy's next attack to deal zero damage" & vbCrLf & "Block - Only works if you have the shield. Negates damage until it breaks" & vbCrLf & "Stats - Displays your stats" & vbCrLf & "Start - Starts a new game" & vbCrLf & "-")
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        My.Forms.Form2.Visible = True
    End Sub




    Public Sub Question()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add(">> WHAT IS THE GOD BEAST")
        lstDisplay.Items.Add(">> WHAT IF I KILL IT")
        lstDisplay.Items.Add(">> IM READY")
        strState = "Question1"
    End Sub

    Public Sub RiddleOne()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("What do you own that others use more than you?")
        lstDisplay.Items.Add("Awaiting response.")
        strState = "riddleone"
        blnRiddle = True
    End Sub
    Public Sub RiddleTwo()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Mary's father has 5 daughters: Nana, Nini, Nunu, and Nono are four of their names. What is the name of his fifth daughter?")
        lstDisplay.Items.Add("Awaiting response.")
        strState = "riddletwo"
        blnRiddle = True
    End Sub
    Public Sub RiddleThree()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("What can travel the world without leaving its corner?")
        lstDisplay.Items.Add("Awaiting response.")
        strState = "riddlethree"
        blnRiddle = True
    End Sub
    Public Sub RiddleFour()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Awaiting response.")
        strState = "riddlefour"
        blnRiddle = True
    End Sub
    Public Sub PassedRiddle()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("You hear the voice again: Correct. You may proceed")
        lstDisplay.Items.Add("The path opens!")
        lstDisplay.Items.Add("Awaiting command.")
        strState = "Waitingforroom"
        blnRiddle = False
        intScore = intScore + 10
    End Sub
    Public Sub Shop()
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("To purchase, type ""shop <item>""")
        lstDisplay.Items.Add("Iron Sword - 10 Bones")
        lstDisplay.Items.Add("Magic Glove - 20 Bones")
        lstDisplay.Items.Add("Chestplate - 50 Bones")
        lstDisplay.Items.Add("Mystery Item - 100 Bones")
    End Sub
    'BATTLES ----------------------------------------------------------------------------------

    Public Sub BattleOne(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a SKELETON!")
        intEnAttack = 1
        intEnHealth = 5
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleTwo(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a ROCK MONSTER!")
        intEnAttack = 2
        intEnHealth = 4
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleThree(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a GIANT SNAKE!")
        intEnAttack = 3
        intEnHealth = 2
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleFour(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a GHOST!")
        intEnAttack = 1
        intEnHealth = 6
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub

    Public Sub BattleFive(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a GIANT SPIDER!")
        intEnAttack = 2
        intEnHealth = 8
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleSix(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter an UNDEAD!")
        intEnAttack = 1
        intEnHealth = 10
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub

    Private Sub HighScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoreToolStripMenuItem.Click
        MessageBox.Show("HighScore: " & My.Settings.HighScore)
    End Sub

    Private Sub MitchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MitchToolStripMenuItem.Click
        MessageBox.Show("Super cool guy. Lead (And only) developer. Give him high fives.")
    End Sub

    Private Sub XanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XanToolStripMenuItem.Click
        MessageBox.Show("Coded a little bit.")
    End Sub

    Private Sub JackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JackToolStripMenuItem.Click
        MessageBox.Show("Never showed up to development, but I felt bad leaving him out.")
    End Sub

    Private Sub GraemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraemeToolStripMenuItem.Click
        MessageBox.Show("Moral support in the form of insults and criticism.")
    End Sub

    Public Sub BattleSeven(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a GIANT WASP!")
        intEnAttack = 3
        intEnHealth = 7
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleEight(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a GHOST KING!")
        intEnAttack = 2
        intEnHealth = 10
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleNine(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a WOLF!")
        intEnAttack = 4
        intEnHealth = 3
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    Public Sub BattleTen(ByRef intHealth As Integer, ByRef intMagic As Integer, intAttack As Integer, ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intShield As Integer)

        lstDisplay.Items.Add("You encounter a SLIME MONSTER!")
        intEnAttack = 1
        intEnHealth = 8
        lstDisplay.Items.Add("-BEGIN BATTLE-")
        blnBattle = True

    End Sub
    '
    '
    '   Enemy Attack Sub
    '
    '
    Public Sub EnemyAttack(ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intHealth As Integer, ByRef strState As String, ByRef intHold As Integer, ByRef blnBattle As Boolean, ByRef blnRiddle As Boolean)
        If blnCharge = True Then
            lstDisplay.Items.Add("")
            If blnBoss = True Then
                lstDisplay.Items.Add("Enemy unleashes their huge attack! " & intEnAttack * 4 & " damage taken!")
                intHealth = intHealth - (intEnAttack * 4)
                blnCharge = False
            Else
                lstDisplay.Items.Add("Enemy unleashes their huge attack! " & intEnAttack * 2 & " damage taken!")
                intHealth = intHealth - (intEnAttack * 2)
                blnCharge = False
            End If
            If intHealth <= 0 Then
                strState = "LOSE"
                lstDisplay.Items.Add("> YOU HAVE LOST")
                lstDisplay.Items.Add("Score: " & intScore)
                If My.Settings.HighScore < intScore Then
                    lstDisplay.Items.Add("HIGH SCORE")
                    My.Settings.HighScore = intScore
                End If
                lstDisplay.Items.Add("To play again, type START")
                blnRiddle = False
                blnBattle = False
                blnBoss = False
            Else
                lstDisplay.Items.Add("")
                lstDisplay.Items.Add("Awaiting command.")
            End If
        Else
            intHold = random.Next(1, 4)
            If intHold = 1 Then
                blnCharge = True
                lstDisplay.Items.Add("")
                lstDisplay.Items.Add("The enemy is preparing for a huge attack!")
            Else
                lstDisplay.Items.Add("")
                lstDisplay.Items.Add("Enemy attacks! " & intEnAttack & " damage taken!")
                intHealth = intHealth - intEnAttack
                If intHealth <= 0 Then
                    strState = "LOSE"
                    lstDisplay.Items.Add("> YOU HAVE LOST")
                    lstDisplay.Items.Add("Score: " & intScore)
                    If My.Settings.HighScore < intScore Then
                        lstDisplay.Items.Add("HIGH SCORE")
                        My.Settings.HighScore = intScore
                    End If
                    lstDisplay.Items.Add("To play again, type START")
                    blnRiddle = False
                    blnBattle = False
                    blnBoss = False
                Else
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Awaiting command.")
                End If
            End If
        End If
    End Sub

    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            strHold = txtInput.Text
            strHold = strHold.ToLower
            lstDisplay.Items.Add("")
            lstDisplay.Items.Add(">" & txtInput.Text)
            If strState = "LOSE" Then
                If strHold <> "start" Then
                    lstDisplay.Items.Add("What are you doing? You lost!")
                End If
            End If
            If strHold = "start" Then
                intHealth = 10
                intBones = 0
                intMagic = 3
                intRooms = 0
                blnCharge = False
                blnBattle = False
                blnShop = False
                blnRiddle = False
                intAttack = 1
                intShield = 0
                intScore = 0
                lstDisplay.Items.Clear()
                lstDisplay.Items.Add("It is late at night. Your car has broken down, it is cold and raining.")
                lstDisplay.Items.Add("")
                lstDisplay.Items.Add("Most terrifyingly, your phone has no service. You decide to settle into a cave for the night.")
                lstDisplay.Items.Add("")
                lstDisplay.Items.Add("You OPEN your TRUNK, and REMOVE your sleeping bag. You settle in, and rest for the night.")
                lstDisplay.Items.Add("")
                lstDisplay.Items.Add("Proceed.")
                strState = "AwaitingProceedStart"
            ElseIf strHold = "stats" Then
                If strState = "LOSE" OrElse strState = "NOTSTARTED" Then
                    lstDisplay.Items.Add("You have no stats to check.")
                Else
                    lstDisplay.Items.Add("Score: " & intScore)
                    lstDisplay.Items.Add("Shield: " & intShield)
                    lstDisplay.Items.Add("Bones: " & intBones)
                    lstDisplay.Items.Add("Magic: " & intMagic)
                    lstDisplay.Items.Add("Attack: " & intAttack)
                    lstDisplay.Items.Add("Health: " & intHealth)
                    lstDisplay.Items.Add("STATS")
                End If
            ElseIf strHold = "advance" Then
                If blnShop = True Then
                    strState = "Waitingforroom"
                End If
                If strState = "Waitingforroom" Then
                    If intRooms >= 20 Then
                        intHold = random.Next(1, 11)
                        If intHold = 1 Then
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("You walk into a very large room. In the center of the room is a strange block of stone with what looks like a lever on the side.")
                            lstDisplay.Items.Add("Do you pull the lever?")
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add(">> YES")
                            lstDisplay.Items.Add(">> NO")
                            strState = "lever"
                        End If
                    End If
                        If strState <> "lever" Then
                        intHold = random.Next(1, 5)
                        intScore = intScore + 1
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("After advancing further into the cave, you stumble into a large clearing.")
                        Select Case intHold
                            Case 1
                                lstDisplay.Items.Add("")
                                lstDisplay.Items.Add("This seems to be a room filled with dusty skeletons, spider webs, and a small chest in the middle of the room.")
                                lstDisplay.Items.Add("")
                                lstDisplay.Items.Add("You open the chest. Dust flies out, but peering through it you see...")
                                intHold = random.Next(1, 9)
                                Select Case intHold
                                    Case 1
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found an IRON SWORD!")
                                        intAttack = intAttack + 1
                                    Case 2
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a MAGIC GLOVE!")
                                        intMagic = intMagic + 2
                                    Case 3
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a SHIELD!")
                                        intShield = intShield + 3
                                    Case 4
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a HEALTH POTION!")
                                        intHealth = intHealth + 5
                                    Case 5
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a LONGSWORD!")
                                        intAttack = intAttack + 2
                                    Case 6
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a HELMET!")
                                        intHealth = intHealth + 3
                                    Case 7
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a CHESTPLATE!")
                                        intHealth = intHealth + 5
                                    Case 8
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("Wow! You found a full set of ARMOR!")
                                        intHealth = intHealth + 10
                                End Select
                                intScore = intScore + 1
                                lstDisplay.Items.Add("")
                                lstDisplay.Items.Add("Awaiting command.")
                            Case 2
                                lstDisplay.Items.Add("")
                                lstDisplay.Items.Add("The way forward is blocked, and you percieve a voice speaking at you from the beyond:")
                                intHold = random.Next(1, 4)
                                blnFirstTry = True
                                Select Case intHold
                                    Case 1
                                        RiddleOne()
                                    Case 2
                                        RiddleTwo()
                                    Case 3
                                        RiddleThree()
                                End Select
                            Case 3 'SHOP
                                lstDisplay.Items.Add("")
                                lstDisplay.Items.Add("In the clearing is a shop with a man behind it.")
                                lstDisplay.Items.Add("")
                                lstDisplay.Items.Add("""Ah, a traveler! It's been many weeks. Welcome! See anything you like?""")
                                blnShop = True
                                Call Shop()
                            Case 4 'BATTLE
                                lstDisplay.Items.Add("")
                                intHold = random.Next(1, 11)
                                Select Case intHold
                                    Case 1
                                        BattleOne(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 2
                                        BattleTwo(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 3
                                        BattleThree(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 4
                                        BattleFour(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 5
                                        BattleFive(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 6
                                        BattleSix(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 7
                                        BattleSeven(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 8
                                        BattleEight(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 9
                                        BattleNine(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                    Case 10
                                        BattleTen(intHealth, intMagic, intAttack, intEnAttack, intEnHealth, intShield)
                                End Select
                                strState = "battle"
                        End Select
                        intRooms = intRooms + 1
                    End If
                End If
                If strState = "AwaitingProceedStart" Then
                    intHold = random.Next(1, 9)
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("You wake up and look around.")
                    Select Case intHold
                        Case 1
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found an IRON SWORD!")
                            intAttack = intAttack + 1
                        Case 2
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a MAGIC GLOVE!")
                            intMagic = intMagic + 2
                        Case 3
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a SHIELD!")
                            intShield = intShield + 3
                        Case 4
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a HEALTH POTION!")
                            intHealth = intHealth + 5
                        Case 5
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a LONGSWORD!")
                            intAttack = intAttack + 2
                        Case 6
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a HELMET!")
                            intHealth = intHealth + 3
                        Case 7
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a CHESTPLATE!")
                            intHealth = intHealth + 5
                        Case 8
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("Wow! You found a full set of ARMOR!")
                            intHealth = intHealth + 10
                    End Select
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Suddenly, you're surrounded by men wearing nothing but strange masks.")
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("They pick you up and bring you to a tent deeper in the cave, lit by a campfire.")
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Their leader walks up to you and asks you a question.")
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("""Strange man, do you know of the wrong you have done?""")
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add(">> YES")
                    lstDisplay.Items.Add(">> NO")
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Awaiting command.")
                    strState = "Question"
                End If
            ElseIf strState = "battle" Then
                If strHold = "attack" Then
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("You attack! Enemy takes " & intAttack & " damage!")
                    intEnHealth = intEnHealth - intAttack
                    If intEnHealth <= 0 Then
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("The enemy falls! Victory!")
                        intHold = random.Next(4, 21)
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("You found " & intHold & " bones!")
                        intBones = intBones + intHold
                        intScore = intScore + 10
                        If blnBoss = True Then
                            intScore = intScore + 100
                            blnBoss = False
                            intRooms = 0
                            lstDisplay.Items.Add("")
                            lstDisplay.Items.Add("You finally killed the beast. Sweat runs down your brow. And yet... You hear laughter coming from deeper in the cave.")
                            lstDisplay.Items.Add("You must press onward.")
                            lstDisplay.Items.Add("")
                        End If
                        strState = "Waitingforroom"
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("Awaiting command.")
                    Else
                        EnemyAttack(intEnAttack, intEnHealth, intHealth, strState, intHold, blnBattle, blnRiddle)
                    End If
                ElseIf strHold = "dodge" Then
                    intHold = random.Next(1, 5)
                    If intHold = 2 Then
                        lstDisplay.Items.Add("")
                        blnCharge = False
                        lstDisplay.Items.Add("Dodged!")
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("Awaiting command.")
                    Else
                        lstDisplay.Items.Add("Dodge failed!")
                        EnemyAttack(intEnAttack, intEnHealth, intHealth, strState, intHold, blnBattle, blnRiddle)
                    End If
                ElseIf strHold = "block" Then
                    If intShield <= 0 Then
                        lstDisplay.Items.Add("You don't have a shield!")
                    Else
                        intShield = intShield - 1
                        blnCharge = False
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("You block the enemy's attack!")
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("Awaiting command.")
                    End If
                ElseIf strHold = "magic" Then
                    If intMagic <= 0 Then
                        lstDisplay.Items.Add("You're out of magic points!")
                    Else
                        intMagic = intMagic - 1
                        intHold = random.Next(1, 5)
                        lstDisplay.Items.Add("")
                        Select Case intHold
                            Case 1
                                lstDisplay.Items.Add("Your magic rejuvinates you...")
                                intHealth = intHealth + 5
                            Case 2
                                lstDisplay.Items.Add("Your magic strikes at the enemy!")
                                intEnHealth = intEnHealth - (intAttack + 3)
                                If intEnHealth <= 0 Then
                                    lstDisplay.Items.Add("")
                                    lstDisplay.Items.Add("The enemy falls! Victory!")
                                    intHold = random.Next(4, 21)
                                    lstDisplay.Items.Add("")
                                    lstDisplay.Items.Add("You found " & intHold & " bones!")
                                    intBones = intBones + intHold
                                    intScore = intScore + 10
                                    If blnBoss = True Then
                                        intScore = intScore + 100
                                        blnBoss = False
                                        intRooms = 0
                                        lstDisplay.Items.Add("")
                                        lstDisplay.Items.Add("You finally killed the beast. Sweat runs down your brow. And yet... You hear laughter coming from deeper in the cave.")
                                        lstDisplay.Items.Add("You must press onward.")
                                        lstDisplay.Items.Add("")
                                    End If
                                    strState = "Waitingforroom"
                                    lstDisplay.Items.Add("")
                                    lstDisplay.Items.Add("Awaiting command.")
                                Else
                                    EnemyAttack(intEnAttack, intEnHealth, intHealth, strState, intHold, blnBattle, blnRiddle)
                                End If
                            Case 3
                                lstDisplay.Items.Add("Your magic summons an epic shield!")
                                intShield = intShield + 4
                            Case 4
                                lstDisplay.Items.Add("Your magic makes you permanently stronger!")
                                intAttack = intAttack + 2
                        End Select
                        If strState <> "Waitingforroom" Then
                            EnemyAttack(intEnAttack, intEnHealth, intHealth, strState, intHold, blnBattle, blnRiddle)
                        End If
                    End If
                End If
            ElseIf strHold = "yes" Then
                If strState = "lever" Then
                    strState = "leveryes"
                    Boss(intEnAttack, intEnHealth, intHealth, strState, intHold, blnBattle, blnRiddle)
                Else
                    If strState <> "Question" Then
                        lstDisplay.Items.Add("Who are you talking to?")
                    Else
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("The mask-wearing men all murmur in excitement.")
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("The leader says to you: ""Then you must know that you are to be punished,")
                        lstDisplay.Items.Add("and will be sacrificed to our god-beast. If you refuse, we shall eat you alive!""")
                        Question()
                    End If
                End If
            ElseIf strHold = "no" Then
                If strState = "lever" Then
                    strState = "leverno"
                    Boss(intEnAttack, intEnHealth, intHealth, strState, intHold, blnBattle, blnRiddle)
                Else
                    If strState <> "Question" Then
                        lstDisplay.Items.Add("Who are you talking to?")
                    Else
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("The leader grunts. ""Then you have the rest of your life to find out.""")
                        lstDisplay.Items.Add("")
                        lstDisplay.Items.Add("""We are peaceful men. But, we must respond to all instances of trespassing")
                        lstDisplay.Items.Add("as forms of aggression. You are to be sacrificed to our god-beast that lives deep in the tunnels.""")
                        Question()
                    End If
                End If
            ElseIf strHold = "what is the god beast" Then
                If strState <> "Question1" Then
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Who are you talking to?")
                Else
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("""The god-beast is our deity. We are not quite sure what it is, but anyone who learns does not live long after.""")
                End If
            ElseIf strHold = "what if i kill it" Then
                If strState <> "Question1" Then
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Who are you talking to?")
                Else
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("The men of the tribe laugh. The leader says, ""If by the slight chance that you are able to kill our god, then we ")
                    lstDisplay.Items.Add("will let you leave with only the memories of your journey.""")
                End If
            ElseIf strHold = "im ready" Then
                If strState <> "Question1" Then
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Who are you talking to?")
                Else
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("The men of the tribe laugh, and the leader remarks, ""You seem rather confident, strange man. Good luck.""")
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("Awaiting command.")
                    strState = "Waitingforroom"
                End If
                '
                '
                '
                '
                '
                '
                '
                '
                'RIDDLES
            ElseIf strHold = "name" OrElse strHold = "your name" OrElse strHold = "my name" Then
                If strState <> "riddleone" Then
                    lstDisplay.Items.Add("Who are you talking to?")
                Else
                    PassedRiddle()
                End If
            ElseIf strHold = "mary" Then
                If strState <> "riddletwo" Then
                    lstDisplay.Items.Add("Who are you talking to?")
                Else
                    PassedRiddle()
                End If
            ElseIf strHold = "stamp" OrElse strHold = "a stamp" OrElse strHold = "stamps" Then
                If strState <> "riddlethree" Then
                    lstDisplay.Items.Add("Who are you talking to?")
                Else
                    PassedRiddle()
                End If
            ElseIf blnShop = True Then 'SHOP STUFF HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
                If strState = "LOSE" OrElse strState = "NOTSTARTED" Then
                    strState = strState
                Else
                    If strHold = "shop iron sword" Then
                        If intBones < 10 Then
                            lstDisplay.Items.Add("Not enough bones!")
                        Else
                            intBones = intBones - 10
                            intAttack = intAttack + 1
                            lstDisplay.Items.Add("Purchased!")
                        End If
                    End If
                    If strHold = "shop magic glove" Then
                        If intBones < 20 Then
                            lstDisplay.Items.Add("Not enough bones!")
                        Else
                            intBones = intBones - 20
                            intMagic = intMagic + 2
                            lstDisplay.Items.Add("Purchased!")
                        End If
                    End If
                    If strHold = "shop chestplate" Then
                        If intBones < 50 Then
                            lstDisplay.Items.Add("Not enough bones!")
                        Else
                            intBones = intBones - 50
                            intHealth = intHealth + 5
                            lstDisplay.Items.Add("Purchased!")
                        End If
                    End If
                    If strHold = "shop mystery item" Then
                        If intBones < 100 Then
                            lstDisplay.Items.Add("Not enough bones!")
                        Else
                            intBones = intBones - 100
                            intHealth = intHealth + 5
                            intMagic = intMagic + 5
                            intShield = intShield + 1
                            intScore = intScore + 100
                            intAttack = intAttack + 1
                            lstDisplay.Items.Add("Purchased!")
                        End If
                    End If
                End If 'END SHOP
            End If
            If blnRiddle = True Then
                If blnFirstTry = True Then
                    blnFirstTry = False
                Else
                    lstDisplay.Items.Add("")
                    lstDisplay.Items.Add("You hear the voice again: Fool! That is incorrect! -1 Health")
                    intHealth = intHealth - 1
                    If intHealth <= 0 Then
                        strState = "LOSE"
                        lstDisplay.Items.Add("> YOU HAVE LOST")
                        lstDisplay.Items.Add("Score: " & intScore)
                        If My.Settings.HighScore < intScore Then
                            lstDisplay.Items.Add("HIGH SCORE")
                            My.Settings.HighScore = intScore
                        End If
                        lstDisplay.Items.Add("To play again, type START")
                        blnRiddle = False
                        blnBoss = False
                        blnBattle = False
                    End If
                End If
            End If
            'REVERSE THE ORDER
            'Dim listBoxPlaceHolder As New ArrayList
            'For i = 0 To lstDisplay.Items.Count - 1 ' Reverse Order
            'listBoxPlaceHolder.Add(lstDisplay.Items.Item(lstDisplay.Items.Count - i - 1))
            'Next
            'lstDisplay.Items.Clear()
            'lstDisplay.Items.AddRange(listBoxPlaceHolder.ToArray)
            txtInput.Text = Nothing
            If lstDisplay.Items.Count >= 25 Then
                Do While lstDisplay.Items.Count >= 25
                    lstDisplay.Items.RemoveAt(0)
                Loop
            End If
        End If
    End Sub
    Public Sub Boss(ByRef intEnAttack As Integer, ByRef intEnHealth As Integer, ByRef intHealth As Integer, ByRef strState As String, ByRef intHold As Integer, ByRef blnBattle As Boolean, ByRef blnRiddle As Boolean)
        lstDisplay.Items.Add("")
        If strState = "leverno" Then
            lstDisplay.Items.Add("You're about to walk past the lever when suddenly")
        ElseIf strState = "leveryes" Then
            lstDisplay.Items.Add("You approach the lever, about to pull it, when suddenly")
        End If
        intHold = random.Next(1, 5)
        Select Case intHold
            Case 1
                lstDisplay.Items.Add("A giant snake erupts from the earth! It hisses at you, daring you to approach the lever and switch it.")
                intEnAttack = 5
                intEnHealth = 50
            Case 2
                lstDisplay.Items.Add("A giant spider crawls out from the walls! It clicks its pincers at you, daring you to approach and switch the lever!")
                intEnAttack = 4
                intEnHealth = 58
            Case 3
                lstDisplay.Items.Add("A tall soldier clad in black, metal armor appears from behind the stone! It hoists its mighty battleaxe into the air, daring you to try to defeat him.")
                intEnAttack = 8
                intEnHealth = 40
            Case 4
                lstDisplay.Items.Add("A mysterious spirit appears in front of you. It conjures a crossbow from the air, and aims it at you!")
                intEnAttack = 3
                intEnHealth = 55
        End Select
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Are you ready?")
        lstDisplay.Items.Add("Begin Boss Battle")
        lstDisplay.Items.Add("Awaiting command.")
        strState = "battle"
        blnBattle = True
        blnBoss = True
    End Sub
End Class

'Items
'Iron sword - +1 Attack
'Magic Glove - +2 Magic
'Shield - +3 Shield
'Health Potion - +5 Health
'Longsword - +2 Attack
'Helmet - +3 Health
'Chestplate - +5 Health
'Full Armor - +10 Health