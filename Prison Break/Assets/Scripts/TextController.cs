using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom,
    corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2,
    corridor_2, courtyard, corridor_3};

    public Text myText;
    States myState;

    // Use this for initialization
    void Start() {
        // Initialise myState to cell
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {

        if (myState == States.cell) { Cell(); }
        else if (myState == States.mirror) { Mirror(); }
        else if (myState == States.sheets_0) { Sheets_0(); }
        else if (myState == States.lock_0) { Lock_0(); }
        else if (myState == States.cell_mirror) { Cell_Mirror(); }
        else if (myState == States.sheets_1) { Sheets_1(); }
        else if (myState == States.lock_1) { Lock_1(); }

        else if (myState == States.corridor_0) { Corridor_0(); }
        else if (myState == States.corridor_1) { Corridor_1(); }
        else if (myState == States.corridor_2) { Corridor_2(); }
        else if (myState == States.corridor_3) { Corridor_3(); }
        else if (myState == States.stairs_0) { Stairs_0(); }
        else if (myState == States.stairs_1) { Stairs_1(); }
        else if (myState == States.stairs_2) { Stairs_2(); }
        else if (myState == States.floor) { Floor(); }
        else if (myState == States.closet_door) { Closet_Door(); }
        else if (myState == States.in_closet) { In_Closet(); }
        else if (myState == States.courtyard) { Courtyard(); }

    }

    void Cell() {

        myText.text = "You wake up in a prison cell, and you want to escape. " +
                      "\nIn the room, there's some dirty sheets on the bed, a mirror on the wall, " +
                      "and the cell door locked from outside.\n\n" +
                      "Press:\n- S to inspect the Sheets\n- M to inspect the Mirror \n- L to inspect the Lock";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.mirror; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_0; }
    }

    void Sheets_0() {
        myText.text = "These sheets are very dirty! I guess you would expect" +
                       " that from a prison. Hopefully they are changed soon!" +
                       "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Lock_0() {
        myText.text = "This is one of those button locks. You have no idea what the"+
            " combination is. You wish you could somehow see where the dirty fingerprints"+
            " were"+
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Mirror() {
        myText.text = "That dirty old mirror on the wall seems loose!"+
            "\n\n Press T to take the mirror, or R to return to the middle of the cell. ";

        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Cell_Mirror() {
        myText.text = "You are still in your cell and you STILL want to escape!"+
            " There are still some dirty sheets on the bed, and the cell door which is"+
            " firmly locked."+
            "\n\nPress S to view the sheets, L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_1; }
    }

    void Sheets_1() {
        myText.text = "Holding a mirror in your hand, won't make the sheets look any better and"+
            " cleaner!"+
            "\n\nPress R to return back to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Lock_1() {
        myText.text = "You carefully put the mirror fragment through the bars, and turn"+
            " it round to see the lock. You can now see the fingerprints on the buttons."+
            " You press the dirty buttons, and hear a click!!"+
            "\n\nPress O to open, R to return back to the cell.";

        if (Input.GetKeyDown(KeyCode.O)) { myState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Corridor_0() {
        myText.text = "Out of the cell, you are welcomed into a corridor. In the"+
            " corridor there's rubbish on the floor, a closet, and a set of stairs."+
            "\n\nPress F to inspect floor, C to check closet, and S to go upstairs.";

        if (Input.GetKeyDown(KeyCode.F)) { myState = States.floor; }
        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_door; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_0; }
    }

    void Stairs_0() {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n"+
            "Press R to go back.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void Floor() {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n"+
            "Press H to collect hairclip, R to go back.";

        if (Input.GetKeyDown(KeyCode.H)) { myState = States.corridor_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void Closet_Door() {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
        "Maybe you could find something around to help enourage it open?\n\n"+
        "Press R to go back.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void Corridor_1() {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?\n\n" +
        "Press S to go upstairs, P to pick closet lock.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_1; }
        else if (Input.GetKeyDown(KeyCode.P)) { myState = States.in_closet; }
    }

    void Stairs_1() {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
        "confidence to walk out into a courtyard surrounded by armed guards!\n\n"+
        "Press R to go back.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_1; }
    }

    void In_Closet() {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up.\n\n" +
           "Press R to return to corridor, D to wear uniform.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_2; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.corridor_3; }
    }

    void Stairs_2() {
        myText.text = "Unfortunately going upstairs, you realise you'll be " +
            "surrounded by armed guards!\n\n" +
            "Press R to go back.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_2; }
    }

    void Corridor_2() {
        myText.text = "Still in the corridor. Floor still dirty. Closet still holding" +
            " cleaner's uniform.\n\n" +
            "Press S to go upstairs, D to dress uniform in closet.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_2; }
        else if (Input.GetKeyDown(KeyCode.D)) { myState = States.in_closet; }
    }

    void Corridor_3() {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner." +
            " You strongly consider the run for freedom.\n\n" +
            "Press U to undress uniform, S to go upstairs.";

        if (Input.GetKeyDown(KeyCode.U)) { myState = States.in_closet; }
        else if (Input.GetKeyDown(KeyCode.S)) { myState = States.courtyard; }
    }

    void Courtyard() {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
                "The guard tips his hat at you as you waltz past, claiming " +
                "your freedom. You heart races as you walk into the sunset.\n\n" +
                "Press P to Play again.";

        if (Input.GetKeyDown(KeyCode.P)) { myState = States.cell; }
    }
}
