import { Component, OnInit, Injector } from '@angular/core';
import { ContentServiceProxy, GetContentOutput } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';
import { MatDialog } from '@angular/material';


@Component({
  selector: 'app-contents',
  templateUrl: './contents.component.html',
  styles: []
})
export class ContentsComponent extends AppComponentBase implements OnInit {

  content: GetContentOutput = new GetContentOutput();

  constructor(
    injector: Injector,
    private _contentService: ContentServiceProxy,
    private _dialog: MatDialog
    ) {
      super(injector);
     }

  ngOnInit() {
  }

}
