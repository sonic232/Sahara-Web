const requestProductDetailsType = 'REQUEST_PRODUCT_DETAILS';
const receiveProductDetailsType = 'RECEIVE_PRODUCT_DETAILS';
const initialState = { forecasts: [], isLoading: false };

export const actionCreators = {
    requestCategoryDetails: productId => async (dispatch, getState) => {
        if (productId === getState().ProductDetails.productId) {
            // Don't issue a duplicate request (we already have or are loading the requested data)
            return;
        }

        dispatch({ type: requestProductDetailsType, productId });

        const url = `api/Sahara/GetProductView?Id=${productId}`;
        const response = await fetch(url);
        const product = await response.json();

        dispatch({ type: receiveProductDetailsType, productId, product });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestProductDetailsType) {
        return {
            ...state,
            chosenProductId: action.productId,
            isLoading: true
        };
    }

    if (action.type === receiveProductDetailsType) {
        const categoryName = action.product.categoryName;
        const categoryId = action.product.categoryId;
        const productName = action.product.name;
        const productDescription = action.product.description;
        const price = action.product.price;

        return {
            ...state,
            chosenProductId: action.productId,
            productCategoryName: categoryName,
            productCategoryId: categoryId,
            productName: productName,
            productDescription: productDescription,
            productPrice: price,
            isLoading: false
        };
    }

    return state;
};