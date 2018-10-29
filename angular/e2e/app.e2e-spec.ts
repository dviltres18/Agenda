import { AgendaTemplatePage } from './app.po';

describe('Agenda App', function() {
  let page: AgendaTemplatePage;

  beforeEach(() => {
    page = new AgendaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
