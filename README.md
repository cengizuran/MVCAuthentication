# MVCAuthentication
In this MVC project, an authentication process is simulated. "username:admin, pw:admin" will assign Admin role to the user and open an admin session, 
"username:member, pw:member" will simulate logging in as a standard member, and all other login attempts will return a "user not found" error. 
Note that, one can only reach the admin panel( /Home/Panel in this case) through login panel. User won't be able to reach this page without an admin session, 
which is only possible through login panel. 
Singleton pattern is used to ensure database is only instanced once.
