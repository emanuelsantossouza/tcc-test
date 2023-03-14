import { IonicModule } from '@ionic/angular';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Tab1Page } from './tab1.page';
import { Tab1PageRoutingModule } from './tab1-routing.module';
import { MenusPageModule } from '../components/menus/menus.module';
import { NavbarPageModule } from '../components/navbar/navbar.module';


@NgModule({
  imports: [
    IonicModule,
    CommonModule,
    FormsModule,
    Tab1PageRoutingModule,
    MenusPageModule,
    NavbarPageModule
  ],
  declarations: [Tab1Page,],
})
export class Tab1PageModule { }
