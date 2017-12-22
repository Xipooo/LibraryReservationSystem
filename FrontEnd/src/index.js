import React from 'react';
import ReactDOM  from 'react-dom';

const HomePage = (
    <div>
        <h2>NorthWest Library</h2>
        <p>
            Welcome to the NorthWest Library! We are the best library around! We have the most imperative selection of media! 
            Check out online and we deliver the media to your door or you can rent digital media, for drop off box near you *click here*.  
            We have space to reserve for study groups, conferences, Lectures, or personal workspace. We have laptops, cameras, and projectors 
            that are available for check-out with the Pro-Library-Account
        </p>
        <img src="https://image.ibb.co/f8iNFR/Team_Waffle_O.png" alt="Team_Waffle_O" class="avatar"/>
        <a href="Reigister_Page">Register</a>
        <a href="Login_Page">Login</a>
    </div>
    
    );

ReactDOM.render(
    HomePage,
    document.getElementById("root")
)