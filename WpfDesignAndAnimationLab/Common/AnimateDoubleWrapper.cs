﻿using System.Windows;
using System.Windows.Media.Animation;

namespace WpfDesignAndAnimationLab.Common
{
    public class AnimateDoubleWrapper : FrameworkElement
    {
        /// <summary>
        /// 标识 Animation 依赖属性。
        /// </summary>
        public static readonly DependencyProperty AnimationProperty =
            DependencyProperty.Register(nameof(Animation), typeof(DoubleAnimation), typeof(AnimateDoubleWrapper), new PropertyMetadata(default(DoubleAnimation), OnAnimationChanged));

        /// <summary>
        /// 标识 Current 依赖属性。
        /// </summary>
        public static readonly DependencyProperty CurrentProperty =
            DependencyProperty.Register(nameof(Current), typeof(double), typeof(AnimateDoubleWrapper), new PropertyMetadata(default(double), OnCurrentChanged));

        /// <summary>
        /// 标识 Target 依赖属性。
        /// </summary>
        public static readonly DependencyProperty TargetProperty =
            DependencyProperty.Register(nameof(Target), typeof(double), typeof(AnimateDoubleWrapper), new PropertyMetadata(default(double), OnTargetChanged));

        private Storyboard _storyboard = new Storyboard();

        /// <summary>
        /// 获取或设置Animation的值
        /// </summary>
        public DoubleAnimation Animation
        {
            get => (DoubleAnimation)GetValue(AnimationProperty);
            set => SetValue(AnimationProperty, value);
        }

        /// <summary>
        /// 获取或设置Current的值
        /// </summary>
        public double Current
        {
            get => (double)GetValue(CurrentProperty);
            set => SetValue(CurrentProperty, value);
        }
        /// <summary>
        /// 获取或设置Target的值
        /// </summary>
        public double Target
        {
            get => (double)GetValue(TargetProperty);
            set => SetValue(TargetProperty, value);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _storyboard.SkipToFill();
        }

        /// <summary>
        /// Animation 属性更改时调用此方法。
        /// </summary>
        /// <param name="oldValue">Animation 属性的旧值。</param>
        /// <param name="newValue">Animation 属性的新值。</param>
        protected virtual void OnAnimationChanged(DoubleAnimation oldValue, DoubleAnimation newValue)
        {
            _storyboard.Children.Clear();
            Storyboard.SetTarget(newValue, this);
            Storyboard.SetTargetProperty(newValue, new PropertyPath(CurrentProperty));

            _storyboard.Children.Add(newValue);
        }

        /// <summary>
        /// Current 属性更改时调用此方法。
        /// </summary>
        /// <param name="oldValue">Current 属性的旧值。</param>
        /// <param name="newValue">Current 属性的新值。</param>
        protected virtual void OnCurrentChanged(double oldValue, double newValue)
        {
        }

        /// <summary>
        /// Target 属性更改时调用此方法。
        /// </summary>
        /// <param name="oldValue">Target 属性的旧值。</param>
        /// <param name="newValue">Target 属性的新值。</param>
        protected virtual void OnTargetChanged(double oldValue, double newValue)
        {
            _storyboard.Stop();
            _storyboard.Begin();
        }

        private static void OnAnimationChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldValue = (DoubleAnimation)args.OldValue;
            var newValue = (DoubleAnimation)args.NewValue;
            if (oldValue == newValue)
                return;

            var target = obj as AnimateDoubleWrapper;
            target?.OnAnimationChanged(oldValue, newValue);
        }

        private static void OnCurrentChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldValue = (double)args.OldValue;
            var newValue = (double)args.NewValue;
            if (oldValue == newValue)
                return;

            var target = obj as AnimateDoubleWrapper;
            target?.OnCurrentChanged(oldValue, newValue);
        }
        private static void OnTargetChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldValue = (double)args.OldValue;
            var newValue = (double)args.NewValue;
            if (oldValue == newValue)
                return;

            var target = obj as AnimateDoubleWrapper;
            target?.OnTargetChanged(oldValue, newValue);
        }
    }
}
