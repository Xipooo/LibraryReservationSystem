import React from 'react'

class HomePage extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            HomePageDescription: '',
            HomePageName: '',
        };
    }

    componentWillMount() {
        fetch('http://localhost:7441/api/homepage/1')
            .then(results => {
                return results.json();
            })
            .then(data => {
                this.setState({ HomePageDescription: data.libraryDescr,
                HomePageName: data.libraryName })
            });

    }
    render() {
        return (
            <div>
                <h1>{this.state.HomePageName}</h1>
                <p>{this.state.HomePageDescription}</p>
            </div>
        )
    }
}



ReactDOM.render(
    <HomePage />,
    document.getElementById("root")
)