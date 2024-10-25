import HomePage from "../pages/saucedemo/answers/homePage";
import ProductsOverviewPage from "../pages/saucedemo/answers/productsOverviewPage";

describe('Exercises 03 - before', () => {
    [
        'standard_user',
        'problem_user',
        'visual_user'
    ].forEach((username) => {

        it(`should successfully log in ${username}`, () => {
            new HomePage()
                .visit()
                .loginAs(username, 'secret_sauce')

            new ProductsOverviewPage().getLinkToBackpack().should('be.visible')
    })
    })

})



