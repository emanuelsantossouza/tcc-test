import { IonicModule } from '@ionic/angular';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Tab2Page } from './tab2.page';

import { Tab2PageRoutingModule } from './tab2-routing.module';
import { MenusPageModule } from '../components/menus/menus.module';
import { NavbarPageModule } from '../components/navbar/navbar.module';

@NgModule({
  imports: [
    IonicModule,
    CommonModule,
    FormsModule,
    Tab2PageRoutingModule,
    MenusPageModule,
    NavbarPageModule
  ],
  declarations: [Tab2Page]
})
export class Tab2PageModule {}
