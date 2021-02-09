import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule, FormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RoutingModule } from './routing/routing.module';
import { HomeComponent } from './home/home.component';
import { MenuComponent } from './menu/menu.component';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserService } from './shared/user.service';
import { LoginComponent } from './user/login/login.component';
import { MenuEditComponent } from './menu-edit/menu-edit.component';
import { MenudetailComponent } from './menudetail/menudetail.component';
import { AdminmenuComponent } from './adminmenu/adminmenu.component';
import { AddmenuComponent } from './addmenu/addmenu.component';
import { ItemDataFormComponent } from './item-data-form/item-data-form.component';
import { ItemsComponent } from './items/items.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MenuComponent,
    UserComponent,
    LoginComponent,
    RegistrationComponent,
    MenuEditComponent,
    MenudetailComponent,
    AdminmenuComponent,
    AddmenuComponent,
    ItemDataFormComponent,
    ItemsComponent
   
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    RoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      progressBar: true
    }),
    FormsModule
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
