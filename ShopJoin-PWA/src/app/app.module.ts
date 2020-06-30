import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';


import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { NavigationComponent } from './navigation/navigation.component';
import { LoginComponent } from './login/login.component';


@NgModule({
   declarations: [
      AppComponent,
      UserComponent,
      NavigationComponent,
      LoginComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
