import { Component, OnInit, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';

@Component({  
  templateUrl: './phonebook.component.html', 
  animations: [appModuleAnimation()]
})
export class PhonebookComponent extends AppComponentBase {

  constructor(injector: Injector) {
    super(injector);
  }
 
}

