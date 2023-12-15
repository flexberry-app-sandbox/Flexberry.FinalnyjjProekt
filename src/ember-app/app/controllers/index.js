import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.кадровые-документы.caption'),
          title: i18n.t('forms.application.sitemap.кадровые-документы.title'),
          children: [{
            link: 'i-i-s-finalnyjj-proekt-расчетный-лист-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-расчетный-лист-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-расчетный-лист-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-finalnyjj-proekt-отделы-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-отделы-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-отделы-l.title'),
            children: null
          }, {
            link: 'i-i-s-finalnyjj-proekt-сотрудники-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-сотрудники-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-сотрудники-l.title'),
            icon: 'building',
            children: null
          }, {
            link: 'i-i-s-finalnyjj-proekt-организации-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-организации-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-организации-l.title'),
            icon: 'briefcase',
            children: null
          }, {
            link: 'i-i-s-finalnyjj-proekt-графики-отпуска-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-графики-отпуска-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-графики-отпуска-l.title'),
            icon: 'chart bar',
            children: null
          }, {
            link: 'i-i-s-finalnyjj-proekt-согласие-на-опд-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-согласие-на-опд-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-согласие-на-опд-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-finalnyjj-proekt-должности-l',
            caption: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-должности-l.caption'),
            title: i18n.t('forms.application.sitemap.кадровые-документы.i-i-s-finalnyjj-proekt-должности-l.title'),
            icon: 'archive',
            children: null
          }]
        }
      ]
    };
  }),
})