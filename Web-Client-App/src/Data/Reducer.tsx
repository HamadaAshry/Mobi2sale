const InitState = {
    DomainName: "http://algosys-001-site8.ctempurl.com",
    Count: 0,
    CategoryName: 'some one',
    subCategoryID: 0,
    Categories:[
        {CategoryID: 1 ,CategoryName: 'users'},
        {CategoryID: 2 ,CategoryName: 'comments'},
        {CategoryID: 3 ,CategoryName: 'posts'},
        {CategoryID: 4 ,CategoryName: 'albums'},
        {CategoryID: 5 ,CategoryName: 'photos'},
        {CategoryID: 6 ,CategoryName: 'todos'},
    ],

    MobileSubCategories: [
        {
            CategoryID: 1,
            CategoryName: 'mobile',
            SubCategoryID: 10,
            SubCategoryNAME: 'Apple',
        },
        {
            CategoryID: 1,
            CategoryName: 'mobile',
            SubCategoryID: 11,
            SubCategoryNAME: 'Samsung',
        }
    ],
    AccessoriesSubCategories: [
        {
            CategoryID: 2,
            CategoryName: 'accessories',
            SubCategoryID: 20,
            SubCategoryNAME: 'remax',
        },
        {
            CategoryID: 2,
            CategoryName: 'accessories',
            SubCategoryID: 21,
            SubCategoryNAME: 'infnix',
        }
    ]
    
}


const Reducer = (state:any = InitState, action:any) => {
    if (action.type === 'INCREASE'){
        return {Count: state.Count + 1}
    } else if (action.type === 'DECREASE'){
        if(state.Count > 0) {
            return {Count: state.Count - 1}
        }
    }

    if (action.type === 'EDITMOBILE') {
        return {
            CategoryName: 'Mobile'
        }
    } else if (action.type === 'EDITACCESSORIES') {
        return {
            CategoryName: 'Mobile'
        }
    }

    if (action.type === "ToggleModal"){
        return {Modal: !state.Modal}
    }
     
    
    return state
}

export default Reducer