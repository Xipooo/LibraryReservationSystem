import React from 'react';
import PropTypes from 'prop-types';
import { render } from 'react-dom';

export default class Header extends React.Component {
    render() {
        return (
            <nav>
                <h1>{this.props.title}</h1>
                <ui>
                    <li>
                        <a href="/">Home</a>
                    </li>
                    <li>
                        <a href="/search">Search</a>
                    </li>
                    <li>
                        <a href="/mine">Mine</a>
                    </li>
                </ui>
            </nav>
        );
    };
}

Header.propTypes = {
    title: PropTypes.string
}