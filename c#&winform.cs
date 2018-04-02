// open a windows form on top of the existing windows form
    // where logintime is the name of the new(already created) windows form you want to open as a child form dependent on the parent.
    // creating an instance 'display' of the windows form 'logintime' and showing the created instance
    logintime display = new logintime();
                display.ShowDialog();


// open a new windows form
    //where reservation is the name of the windows form you just want to open.(this does not depend on the windows form that opened it)
    // creating an instance 'display' of the windows form 'reservation' and showing the created instance
    reservation display = new reservation();
                display.Show();

// close the present windows form you are on
    this.Close();

// close the whole application you are running
    Application.Exit();

//hide the presents acnt windows form you are on  
    this.Hide();

// to open page 2 that only gracess to page three only if page 2 conditions are met
    //this is page 1 opening page 2 with a condition to close page 1 only if page twos requirement are met (dialogResult.OK)
    login2 display = new login2();
                DialogResult dr = display.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    this.Close();
                }

    //this is page 2 setting condition to close page one to true and opening page 3(admin) then it closes it self
    this.DialogResult = DialogResult.OK;
                        admin display = new admin();
                        display.Show();

                    
                        this.Close();

//copy data from sqlite database and putting in datagridview 
    // name of the datagridview is 'lodged'
    string dbconnection = @"Data Source=location of your database file; Version=3";
    SQLiteConnection sqliteconnect = new SQLiteConnection(dbconnectionstring);
    sqliteconnect.Open();
    string query = "SELECT * FROM guests ";
    SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(query, sqliteconnect);
    DataSet ds = new System.Data.DataSet();

    dataadapter.Fill(ds);
    lodged.DataSource = ds.Tables[0];

    sqliteconnect.Close();

//query the database to see if username and password exist in database
    string dbconnection = @"Data Source=location of your database file; Version=3";
    SQLiteConnection sqliteconnect = new SQLiteConnection(dbconnectionstring);
    sqliteconnect.Open();
    string query = "SELECT * FROM login where username = '"+var_username+"' and password = '"+var_password+"'";
    SQLiteCommand createCommand = new SQLiteCommand(query, sqliteconnect);
    createCommand.ExecuteNonQuery();
    SQLiteDataReader dr = createCommand.ExecuteReader();
    int count = 0;
    while (dr.Read())
    {
         count++;
    }
    sqliteconnect.Close();
    if (count == 1){
        MessageBox.Show("Login successful");
    }else{
        MessageBox.Show("Login Failed");
    }
//using foreach loop
    string[] name = new string[5]{"SAM","TONY","PICKLE","JACK","VICTORIA"};
    foreach(string X in name){
        Console.WriteLine(X);
    }

//split a string 
    string shinning = "Victoria is a girl"
    // split the contents in variable shinning
    string [] words = shinning.Split(' ');
    // printing the result out
    foreach(string word in words){
        Console.WriteLine(word);
    }

// join all the contents of an array a "stringed" character
     // Create an array with five strings.
        string[] array = new string[5];
        array[0] = "carrot";
        array[1] = "cucumber";
        array[2] = "radish";
        array[3] = "beet";
        array[4] = "potato";
        string result = string.join(" ",array);

// number the data in the datagridview after creating a column s/n in the datagridview
 private void numberdata()
        {
            // where "allreservations" is the name of the grid
            int count = 0;
            int cellnum = 0;
            int rownum = 0;
            foreach (DataGridViewRow row in allreservations.Rows)
            {
                count++;
            }
            for (int i = 1; i < count; i++)
            {
                cellnum = cellnum + 1;
                allreservations.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
                
            }
        }

// fill the datagrid with the data queried from the database
    //string dbconnectionstring = @"Data Source=mikagn_hotel.db; Version=3";
            try
            {
                SQLiteConnection Sqlconnect = new SQLiteConnection(dbconnectionstring);
                Sqlconnect.Open();
                string query = "SELECT * FROM reservation";
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(query, Sqlconnect);
                DataSet ds = new System.Data.DataSet();

                dataadapter.Fill(ds);
                //where "allreservations" is the name of the datagridview
                allreservations.DataSource = ds.Tables[0];


                Sqlconnect.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

//get the date in c# format
    DateTime.Now.ToString("dd/MM/yyyy");