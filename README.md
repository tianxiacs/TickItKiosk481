-------------------------------CPSC 481: Group Project -  Read Me -----------------------------------------------------
Group 10 - Tick-It Theatre TVM

Members:
Hrithvik Gadhiya (hrithvikmanoj.gadhiy@ucalgary.ca)
Yuan Liu (yuan.liu1@ucalgary.ca)
Shehzan Murad Ali (shehzan.muradali@ucalgary.ca)
Zhezheng Wang (zhezheng.wang1@ucalgary.ca)
Tian Xia (tian.xia2@ucalgary.ca)

Procedure to start up the Tick-It interface:
1. Extract all the contents of the "TickIt481-master.zip" and store it in a folder called "TickItKiosk481-master"
2. Open Visual Studio 2019
3. Click on "Open a project or solution"
4. Navigate yourself to the TickIT folder Path you extracted in step 1 and open it.
5. Then, open "TickItKiosk481-master" folder.
6. Then, open "TickItKiosk481.sln" file.
7. From the menu bar, click on the play button.
8. Then, the code will be executed and you will see the main screen.

Steps to use the Tick-It interface and the cases implemented:
1. From the main window, click on the language you want to interact in with the kiosk
2. This screen is the show_selection screen, at any point if you want to change the language, you can select the
   "Language" button on the bottom left corner of the screen to change the language, or if you want help at any point
   of the procedure (in real life) press "Help" button for assistance.
3. If you want to scan the membership from the show selection window, simply press on the "Scan membership card"
   button on right top corner.
4. Then, go ahead and use the barcode scanner to scan the barcode of the membership card as shown on the screen. For
   the instance of this demo, we have created the stubs (for Johnny and Lori), press any of them if you wish.
5. You can select any movie from the show selection screen, which will bring you to the show time selection screen.
6. Press on the available timings of your choice, the unavailable timings (grayed out) cannot be selected.
7. Ticket Selection screen will appear where you can use the +/- buttons to add or subtract the tickets from different
   categories. If a member is signed in they can also redeem tickets til the limit is reached. If a user is not signed
   in then the the "Point Redemption" is grayed out. After selecting the tickets press on "Select Seats >>" to continue.
8. You can then interact with thhe seat map to select any seats, unselect them if you want. Try not selecting all tickets,
   it will prompt you to select them, with an error message. After selecting your desired tickets select on 
   "Select Food >>".
9. A popup will appear showing that you now have 4 minutes to complete the reservation, or else the selected seats will
   be given up. After pressing continue, you can use +/- to add or subtract food items of your choice. 
10. If you want to go back at this point, the Kiosk will show up another popup confirming that the seats will be given up
    if you really want to go back.
11. At any point if the 4 minutues timer runs out, a new screen appears saying that the timeout has been reached, and 
    asking the user to restart the transaction with a button leading back to the main/standby screen.
12. After selecting the desired food items from step 9, you can press "Checkout >>" to continue. Which will show all
    the available options to pay from. Select Credit/Debit card option on the right hand side of the screen
13. This will bring you to a screen which has instructions to complete the transaction. We have a stub in place to 
    simulate this called "Successfully Pay"
14. You can also go back by pressing at "Selecting another payment method" to go back to Order review page.
15. You can try paying via Giftcard by pressing on "Gift Card" option from righht hand side.
16. This will open up a screen giving instructions to scan the barcode of the giftcard. For the sake of this demo, we 
    have a stub in place called "Successfully Pay" to simulate this process.
17. After clicking on the stub, you get to the order completed screen which has an option to print the receipt, or
    start over a new transaction. 

Cases Implemented:
1. Membership scanning via barcode
2. Selecting Show with and without membership scanned
3. Selecting Show Timings with and without membership scanned
4. Selecting Seats 
5. Selecting Food items with timer
6. Giving up seats, if you want to go back
7. Timeout case
8. Payment types
9. Transaction completed
10. Miscellaneous cases such as: obtaining Help, changing Language, going Back a screen
 
