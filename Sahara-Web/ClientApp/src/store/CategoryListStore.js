const requestCategoryListType = 'REQUEST_CATEGORY_LIST';
const receiveCategoryListType = 'RECEIVE_CATEGORY_LIST';
const initialState = { categories: [], isLoading: false };

export const actionCreators = {
    requestCategoryList: () => async (dispatch, getState) => {
        if (startDateIndex === getState().weatherForecasts.startDateIndex) {
            // Don't issue a duplicate request (we already have or are loading the requested data)
            return;
        }

        dispatch({ type: requestCategoryListType });

        const url = `api/Sahara/GetCategoryList`;
        const response = await fetch(url);
        const categories = await response.json();

        dispatch({ type: receiveCategoryListType, categories });
    },

    setCategory: categoryId => ({ type: setChosenCategory, chosenCategoryId: categoryId })
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
            categories: action.categories,
            isLoading: false
        };
    }

    return state;
};