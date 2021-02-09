import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html', 

  styleUrls: ['./app.component.css']
})
export class AppComponent {
  query : string;
  dishes :object;
  title = 'BakedInHeaven';

  constructor()
  {
    
    this.query = 'Chicken Biriyani'

    this.dishes=[
      {
        "name":"Chicken Biriyani",
        "Nutrient":"200 Kcal",
        "Price":"200 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"Dosa",
        "Nutrient":"200 Kcal",
        "Price":"100 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"Idly",
        "Nutrient":"200 Kcal",
        "Price":"50 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"Pizza",
        "Nutrient":"200 Kcal",
        "Price":"300 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"Burger",
        "Nutrient":"200 Kcal",
        "Price":"200 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"Sandwich",
        "Nutrient":"200 Kcal",
        "Price":"200 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"French Fries",
        "Nutrient":"200 Kcal",
        "Price":"200 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      {
        "name":"Butter chicken",
        "Nutrient":"200 Kcal",
        "Price":"200 Rupees",
        "Ingredients":"Vegetable, Spice, Meat, Yogurt, Dried fruit, Garlic, Mint, Rice, Egg, Mint leaf"
      },
      
    ]
  }
}
