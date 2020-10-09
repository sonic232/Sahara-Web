import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { NavDropdown, MenuItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import { actionCreators } from '../store/CategoryListStore';
import './NavMenu.css';

class NavList extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        this.props.requestCategoryList();
    }

    render() {
        return (
            <Navbar inverse fixedTop fluid collapseOnSelect>
                <Navbar.Header>
                    <Navbar.Brand>
                        <Link to={'/'}>Sahara Web Catalog</Link>
                    </Navbar.Brand>
                    <Navbar.Toggle />
                </Navbar.Header>
                <Navbar.Collapse>
                    <Nav>
                        <LinkContainer to={'/'} exact>
                            <NavItem>
                                <Glyphicon glyph='home' /> Home
                            </NavItem>
                        </LinkContainer>
                        <NavDropdown title='Categories' id='nav-dropdown'>
                            {renderCategoriesList(this.props)}
                        </NavDropdown>
                    </Nav>
                </Navbar.Collapse>
            </Navbar>
        );
    }
}

function renderCategoriesList(props) {
    return (
        props.categories.map(category =>
                <MenuItem key={category.id}>
                    <LinkContainer to={`/category/${category.id}`} exact>
                        <NavItem>
                            {category.name}
                        </NavItem>
                    </LinkContainer>
                </MenuItem>
                )
            );
}

export default connect(state => state.categoryList, dispatch => bindActionCreators(actionCreators, dispatch))(NavList);
