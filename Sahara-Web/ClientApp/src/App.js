import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import CategoryDetails from './components/CategoryDetails';
import ProductDetails from './components/ProductDetails';

export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/category/:categoryId?' component={CategoryDetails} />
    <Route path='/product/:productId?' component={ProductDetails} />
  </Layout>
);
