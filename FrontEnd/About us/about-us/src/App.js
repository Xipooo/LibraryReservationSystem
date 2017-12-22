import React, { Component } from 'react';
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
        <div className="App-header">
          <div className="App-title">
           <h2>About Us and Contact Us</h2>
          </div>
        </div>
        <div>
          <h2>About Us</h2>
          <p>Hello! This is a placeholder! our address is 400 Broad St, Seattle, WA 98109</p>
        </div>
        <div>
            <h2>Contact Us</h2>
            <textarea placeholder="email here"></textarea>
            <textarea placeholder="phone number herenp"></textarea>
        </div>
        
      </div>
    );
  }
}
export default App;