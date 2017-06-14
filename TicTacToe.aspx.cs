using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TicTacToe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    static int turn = 1;
    int[] click = { 0,0,0,0,0,0,0,0,0,0};
    int player = 0, comp = 0, gameswon=0;

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_topleft_Click(object sender, EventArgs e)
    {
        if(turn%2!=0)
        {
            Button_topleft.Text = "X";
            turn++;
            click[1] = 1;
            Button_topleft.Enabled = false;
            compturn();
        }
        else
        {
            Button_topleft = Button_topleft.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_topmiddle_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_topmiddle.Text = "X";
            turn++;
            click[2] = 1;
            Button_topmiddle.Enabled = false;
            compturn();
        }
        else
        {
            Button_topmiddle.Text = Button_topmiddle.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_topright_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_topright.Text = "X";
            turn++;
            click[3] = 1;
            Button_topright.Enabled = false;
            compturn();
        }
        else
        {
            Button_topright.Text = Button_topright.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_centerleft_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_centerleft.Text = "X";
            turn++;
            click[4] = 1;
            Button_centerleft.Enabled = false;
            compturn();
        }
        else
        {
            Button_centerleft.Text = Button_centerleft.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_centermiddle_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_centermiddle.Text = "X";
            turn++;
            click[5] = 1;
            Button_centermiddle.Enabled = false;
            compturn();
        }
        else
        {
            Button_centermiddle.Text = Button_centermiddle.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_centerright_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_centerright.Text = "X";
            turn++;
            click[6] = 1;
            Button_centerright.Enabled = false;
            compturn();
        }
        else
        {
            Button_centerright.Text = Button_centerright.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_bottomleft_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_bottomleft.Text = "X";
            turn++;
            click[7] = 1;
            Button_bottomleft.Enabled = false;
            compturn();
        }
        else
        {
            Button_bottomleft.Text = Button_bottomleft.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_bottommiddle_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_bottommiddle.Text = "X";
            turn++;
            click[8] = 1;
            Button_bottommiddle.Enabled = false;
            compturn();
        }
        else
        {
            Button_bottommiddle.Text = Button_bottommiddle.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_bottomright_Click1(object sender, EventArgs e)
    {
        if (turn % 2 != 0)
        {
            Button_bottomright.Text = "X";
            turn++;
            click[9] = 1;
            Button_bottomright.Enabled = false;
            compturn();
        }
        else
        {
            Button_bottomright.Text = Button_bottomright.Text;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    public void compturn()
    {
        Random rnd = new Random();
        int number = rnd.Next(1,10);

        switch (number)
        {
            case 1:
                if (click[1] == 1)
                    compturn();
                else
                { 
                    Button1.Text = "O";
                    Button1.Enabled = false;
                    click[1] = 1;
                    turn++;
                }
                break;

            case 2:
                if (click[2] == 1)
                    compturn();
                else
                {
                    Button2.Text = "O";
                    Button2.Enabled = false;
                    click[2] = 1;
                    turn++;
                }
                break;

            case 3:
                if (click[3] == 1)
                    compturn();
                else
                {
                    Button3.Text = "O";
                    Button3.Enabled = false;
                    click[3] = 1;
                    turn++;
                }
                break;

            case 4:
                if (click[4] == 1)
                    compturn();
                else
                {
                    Button4.Text = "O";
                    Button4.Enabled = false;
                    click[4] = 1;
                    turn++;
                }
                break;

            case 5:
                if (click[5] == 1)
                    compturn();
                else
                {
                    Button5.Text = "O";
                    Button5.Enabled = false;
                    click[5] = 1;
                    turn++;
                }
                break;

            case 6:
                if (click[6] == 1)
                    compturn();
                else
                {
                    Button6.Text = "O";
                    Button6.Enabled = false;
                    click[6] = 1;
                    turn++;
                }
                break;

            case 7:
                if (click[7] == 1)
                    compturn();
                else
                {
                    Button7.Text = "O";
                    Button7.Enabled = false;
                    click[7] = 1;
                    turn++;
                }
                break;

            case 8:
                if (click[8] == 1)
                    compturn();
                else
                {
                    Button8.Text = "O";
                    Button8.Enabled = false;
                    click[8] = 1;
                    turn++;
                }
                break;

            case 9:
                if (click[9] == 1)
                    compturn();
                else
                {
                    Button9.Text = "O";
                    Button9.Enabled = false;
                    click[9] = 1;
                    turn++;
                }
                    break;
        }
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_Playagain_Click(object sender, EventArgs e)
    {
        Button_topleft.Text = "";
        Button_topleft.Enabled = true;
        Button_topmiddle.Text = "";
        Button_topmiddle.Enabled = true;
        Button_topright.Text = "";
        Button_topright.Enabled = true;
        Button_centerleft.Text = "";
        Button_centerleft.Enabled = true;
        Button_centermiddle.Text = "";
        Button_centermiddle.Enabled = true;
        Button_centerright.Text = "";
        Button_centerright.Enabled = true;
        Button_bottomleft.Text = "";
        Button_bottomleft.Enabled = true;
        Button_bottommiddle.Text = "";
        Button_bottommiddle.Enabled = true;
        Button_bottomright.Text = "";
        Button_bottomright.Enabled = true;
    }

    //Applied Rename Method refactoring pattern
    //Applied 'Add Parameter' refactoring method
    protected void Button_Reset_Click(object sender, EventArgs e)
    {
        Button_topleft.Text = "";
        Button_topleft.Enabled = true;
        Button_topmiddle.Text = "";
        Button_topmiddle.Enabled = true;
        Button_topright.Text = "";
        Button_topright.Enabled = true;
        Button_centerleft.Text = "";
        Button_centerleft.Enabled = true;
        Button_centermiddle.Text = "";
        Button_centermiddle.Enabled = true;
        Button_centerright.Text = "";
        Button_centerright.Enabled = true;
        Button_bottomleft.Text = "";
        Button_bottomleft.Enabled = true;
        Button_bottommiddle.Text = "";
        Button_bottommiddle.Enabled = true;
        Button_bottomright.Text = "";
        Button_bottomright.Enabled = true;

        Result.Text = "";
        gwon.Text = "";

    }
}

