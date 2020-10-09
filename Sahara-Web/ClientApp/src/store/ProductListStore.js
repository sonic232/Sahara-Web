const requestProductListType = 'REQUEST_PRODUCT_LIST';
const receiveProductListType = 'RECEIVE_PRODUCT_LIST';
const initialState = { products: [], isLoading: false };

export const actionCreators = {
    requestProductList: () => async (dispatch, getState) => {
        dispatch({ type: requestProductListType });

        const url = `api/Sahara/GetProductListView`;
        const response = await fetch(url);
        const products = await response.json();

        dispatch({ type: receiveProductListType, products });
    },
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestProductListType) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveProductListType) {
        return {
            ...state,
            products: action.products,
            isLoading: false
        };
    }

    return state;
};