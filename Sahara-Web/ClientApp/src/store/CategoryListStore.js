const requestCategoryListType = 'REQUEST_CATEGORY_LIST';
const receiveCategoryListType = 'RECEIVE_CATEGORY_LIST';
const initialState = { categories: [], isLoading: false };

export const actionCreators = {
    requestCategoryList: () => async (dispatch) => {
        dispatch({ type: requestCategoryListType });

        const url = `api/Sahara/GetCategoryList`;
        const response = await fetch(url);
        const json = await response.json();

        dispatch({ type: receiveCategoryListType, json });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestCategoryListType) {
        return {
            ...state,
            isLoading: true
        };
    }

    if (action.type === receiveCategoryListType) {
        return {
            ...state,
            categories: action.json.categories,
            isLoading: false
        };
    }

    return state;
};