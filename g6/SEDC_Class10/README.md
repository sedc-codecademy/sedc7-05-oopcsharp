# Exercise
### Create an Academy Management app
The app will have users that can login and perform some actions.
The user can choose one of the 3 roles and login:
* Admin
* Trainer
* Student ( has a current Subject, and Grades )

After logging in there should be different options for different roles:
* Admins can add/remove Trainers , Students and other Admins ( can't remove it self )
* Trainer can choose between seeing all students and all subjects
	*	When choosing Students, all student names should appear
	*	When chosen a name, it should print all the grades
	*  When choosing Show Subjects, all Subject names appear with how many students attend it next to it
* Students can choose to enrol in a subject and show grades
* Enrol will give the student subjects for the student to choose and whichever one it chooses will be it's current subject
* Show Grades will show all the grades in format: Subject Name : Grade ( Ex: Math : 5 )

Try and handle all scenarios with exception handling. Handle expected exceptions with special messages.  