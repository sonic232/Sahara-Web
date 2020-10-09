const requestCategoryDetailsType = 'REQUEST_CATEGORY_DETAILS';
const receiveCategoryDetailsType = 'RECEIVE_CATEGORY_DETAILS';
const setChosenCategory = 'SET_CATEGORY_ID';
const initialState = { chosenCategoryId: 0, categoryName: '', categoryDescription: '', products: [], isLoading: false };

export const actionCreators = {
    requestCategoryDetails: categoryId => async (dispatch, getState) => {
        if (categoryId === getState().CategoryDetails.chosenCategoryId) {
            // Don't issue a duplicate request (we already have or are loading the requested data)
            return;
        }

        dispatch({ type: requestCategoryDetailsType, categoryId });

        const url = `api/Sahara/GetCategoryView?Id=${categoryId}`;
        const response = await fetch(url);
        const category = await response.json();

        dispatch({ type: receiveCategoryDetailsType, categoryId, category });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestCategoryDetailsType) {
        return {
            ...state,
            chosenCategoryId: action.categoryId,
            isLoading: true
        };
    }

    if (action.type === receiveCategoryDetailsType) {
        const categoryName = action.category.categoryName;
        const categoryDescription = action.category.categoryDescription;
        const products = action.category.products;

        return {
            ...state,
            chosenCategoryId: action.categoryId,
            categoryName: categoryName,
            categoryDescription: categoryDescription,
            products: products,
            isLoading: false
        };
    }

    if (action.type === setChosenCategory) {
        return {
            ...state,
            categoryId: action.chosenCategoryId
        }
    }

    return state;
};