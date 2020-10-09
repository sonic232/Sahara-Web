import React, { Component } from 'react';
import { connect } from 'react-redux';
import ProductList from './ProductList';
import { actionCreators } from '../store/ProductListStore'
import { bindActionCreators } from 'redux';

class Home extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        this.props.requestProductList();
    }

    render() {
        return (
            <div>
                <h1>Welcome to Sahara, your one-stop material shop!</h1>
                <p>With our patented Redstone Warehouse system, you can create a variety of orders easily and securely. A cart will be dispatched to the warehouse to fulfill your order on site. This is a catalogue of our current stock.</p>
                <ProductList />
            </div>
        );
    }
}

export default connect(state => state.productList, dispatch => bindActionCreators(actionCreators, dispatch))(Home);
