# TELEMEDICINEAPP(DAKTARISASA)-DISTRIBUTED-SYSTEM
This is a telemedicine app that allows patients to schedule appointments with doctors, have video consultations, and receive prescription medications. The app has both a backend and a frontend, with the backend built using Django Rest Framework and the frontend built using ASP.NET Razor Pages.

## Features
#### Patient Registration and Login 
Patients can:- 
- Create an account 
- Log in 
- View their profile.

#### Doctor Registration and Login 
Doctors can:- 
- Create an account 
- Log in
- View their profile.

#### Appointment Scheduling 
Patients can:- 
- View a list of available doctors 
- Select a doctor 
- Schedule an appointment with the selected doctor.

#### Video Consultation 
Patients can have a video consultation with a doctor at the scheduled time of their appointment.
#### Prescription Medication 
Doctors can prescribe medication to patients, which can be viewed by patients in their profile.
#### Payment 
Patients can pay for appointments and medication through the app using a credit card.

## Technologies Used
- Django Rest Framework
- ASP.NET Razor Pages
- MySQL
- HTML/CSS/JavaScript

## Installation and Usage
- Clone the repository to your local machine.
- Set up a virtual environment for the Django backend and install the necessary packages using pip install -r requirements.txt.
- Create a MySQL database and run the migrations using python manage.py migrate.
- Create a superuser account for the Django backend using python manage.py createsuperuser.
- Start the Django backend server using python manage.py runserver.
- Open the ASP.NET Razor Pages project in Visual Studio and set up the database connection to the same MySQL database.
- Start the ASP.NET Razor Pages frontend server.
- Navigate to `http://localhost:8000` in your web browser to access the app.

## Future Work
- Implement more robust payment processing using a third-party service.
- Implement chat functionality for patients and doctors to communicate outside of appointments.
- Allow patients to rate and provide feedback on doctors after appointments.
- Implement Daraja api as a payment gateway.
