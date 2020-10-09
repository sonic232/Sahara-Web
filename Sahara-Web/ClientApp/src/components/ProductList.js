import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

class ProductList extends Component {
    render() {
        return (
            <div>
                <h1>Products</h1>
                {renderProductsList(this.props)}
            </div>
        );
    }
}

function renderProductsList(props) {
    return (
        <table className='table'>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Price</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                {props.products.map(product =>
                    <tr key={product.id}>
                        <td>{product.name}</td>
                        <td>{product.price}</td>
                        <td><Link to={`/product/${product.id}`}>details</Link></td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}

export default connect(
    state => state.productList
)(ProductList);
