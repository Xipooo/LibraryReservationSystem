import React from 'react';
import ReactDOM from 'react-dom';

class HomePage extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <div>
        <img src="http://image.ibb.co/ceTBHG/WaffleO.png" alt="WaffleO" border="0" />        
        <a href="Register_Page">Register</a>
        <a href="Login_Page">Login</a>
            </div>
        );
    }
}
ReactDOM.render(
    <HomePage/>,
    document.getElementById("root")
)