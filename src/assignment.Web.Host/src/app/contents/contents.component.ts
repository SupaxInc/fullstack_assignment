import { Component, OnInit, Injector } from '@angular/core';
import { GetContentOutput, ContentServiceProxy } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';
import { ActivatedRoute } from '@angular/router';
import { ContentsService } from './contents.service';

@Component({
  selector: 'app-contents',
  templateUrl: './contents.component.html',
  styleUrls: ['./contents.component.css']
})
export class ContentsComponent extends AppComponentBase implements OnInit {

  contents: GetContentOutput[] = [];

  constructor(
    injector: Injector,
    private service: ContentsService
    ) {
      super(injector);
      this.contents = this.service.contents;
     }

  ngOnInit() {
    
  }

}
