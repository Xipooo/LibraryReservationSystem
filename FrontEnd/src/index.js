import React from 'react';
import ReactDOM from 'react-dom';

class HomePage extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            HomePageDescription: '',
        };
    }

componentWillMount() {
    fetch ('http://localhost:7441/api/homepage')
    .then(results => {
        return results.json();
    }) .then(data => {
        let HomePageDescription = data.results.map((paragraph) => {
        return(
            <div key={paragraph.results}>
                <p> {paragraph.HomePageDescription.libraryDescr} </p>
            </div>
        )
        })
        this.setState({HomePageDescription: HomePageDescription})
    })
    
    }
render() {
    return (
        <div>
            {this.state.HomePageDescription}
        </div>
    )
}
}

ReactDOM.render(
    <HomePage/>,
    document.getElementById("root")
)