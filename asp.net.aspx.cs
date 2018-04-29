// running a command only when the form is submitted
    if(IsPostBack){
        //code goes here
        // this executes the code here when the form is submitted not when the form is first presented to the user
        // isPostBack will be false when the page is first presented but true when the page is submitted again with the post method
    }
    // another way to do this is to add a button click event "OnClick" to the button by referencing it to the button ID.
    OnClick = "buttonID_Click"

// having a literal is cool just like a label anf you can change its text after you have performed some functions on the page.
    literalID.Text = "Something new"

